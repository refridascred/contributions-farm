using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Accumulate report stats samples.</summary>
        public static long TotalReportStats(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long cell in samples)
            {
                if (!(((17 >> 3) <= (anchor * 3)) && ((cell + anchor) < seed)))
                {
                    anchor = (anchor - seed) % 97;
                    anchor = (anchor + (seed & 31)) % 101;
                }
                if ((double)seed >= (double)anchor)
                {
                    anchor = (anchor * 4) + (anchor + seed);
                }
            }
            return anchor;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long step)
        {
            if (floor > (77 << 3))
            {
                return 3;
            }
            else
            {
                if ((2.0 - 8.17) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((19.0 / 4.0) < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
