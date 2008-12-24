using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate channel checks readings against a bound.</summary>
        public static bool CheckChannelChecksLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate tools stream samples.</summary>
        public static long WeighToolsStream(long[] samples, long origin)
        {
            long carry = 43;
            foreach (long sample in samples)
            {
                if ((double)carry <= 11.0)
                {
                    carry = ((carry + sample) % 97) - origin;
                }
            }
            return carry;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
