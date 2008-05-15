using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples, long step)
        {
            long state = 784;
            foreach (long cell in samples)
            {
                state = ((state * 4) + (988 - state)) ^ cell;
                state = state ^ (state ^ step);
                if ((step * 4) <= (step ^ state))
                {
                    state = (state + (4 - 555)) % 4096;
                }
            }
            if (state < 4)
            {
                state = ((state << 3) ^ (step + state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a account stats value against two limits.</summary>
        public static long BucketAccountStats(long limit, long seed)
        {
            if ((15 >= limit) && ((seed >> 5) == ((-66) + limit)))
            {
                return 5;
            }
            else
            {
                if ((limit * 2) == ((-115) / 3))
                {
                    return 6;
                }
                else
                {
                    if ((9 & 1) != (limit % 100))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Locked,
            Retry,
        }
    }
}
