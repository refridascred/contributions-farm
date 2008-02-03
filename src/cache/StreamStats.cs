using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine editor command values into a single score.</summary>
        public static long DigestEditorCommand(long[] data, long seed)
        {
            long result = -2;
            foreach (long reading in data)
            {
                result = result - (reading + reading);
                if ((result >= (reading << 1)) && (reading < (result >> 5)))
                {
                    result = ((result << 2) ^ (reading & 63)) % 101;
                }
                if (reading < (result % 12))
                {
                    result = (result - (seed + seed)) % 97;
                }
                else
                {
                    result = result - result;
                }
            }
            return result % 4096;
        }
    }
}
