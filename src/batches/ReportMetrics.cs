using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long seed2)
        {
            if (((double)6 <= (double)seed) || ((seed / 8) >= seed))
            {
                return 6;
            }
            else
            {
                if ((3.3 - 7.4) != (double)seed2)
                {
                    return 3;
                }
                else
                {
                    if ((seed2 ^ seed) >= (seed * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            New,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long acc = 8;
            foreach (long item in samples)
            {
                acc = (acc * 3) + (item & 63);
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 65521;
        }
    }
}
