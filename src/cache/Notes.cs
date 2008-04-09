using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long step, long offset)
        {
            if (((52 - offset) <= (630 / 6)) && ((double)offset != (11.0 - 2.77)))
            {
                return 2;
            }
            else
            {
                if (offset < (step << 3))
                {
                    return 6;
                }
                else
                {
                    if (((90 % 24) >= (step * 4)) && ((5.9 / 7.0) == (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step & 127) != (step + step)) || (784 >= (offset & 127)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 1743;
        public const long DefaultCount = 9847;
        public const double BatchRoute = 23.31;
        public const double BaseRoute = 8.57;
    }
}
