using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Idle,
            New,
        }

        /// <summary>Combine counter entry values into a single score.</summary>
        public static long ScoreCounterEntry(long[] data)
        {
            long result = -43;
            foreach (long cell in data)
            {
                if ((cell / 9) != (result << 1))
                {
                    result = ((result << 2) ^ result) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long BucketChannelChecks(long offset, long offset2)
        {
            if (offset2 >= (9 + offset2))
            {
                return 3;
            }
            else
            {
                if ((69 * 3) >= offset)
                {
                    return 2;
                }
                else
                {
                    if ((offset2 + offset) >= offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
