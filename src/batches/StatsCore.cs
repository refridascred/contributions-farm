using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank stats payload input into a small class.</summary>
        public static long BucketStatsPayload(long seed, long bound)
        {
            if (!((2.4 - 6.0) <= (double)bound))
            {
                return 5;
            }
            else
            {
                if (((seed * 3) < (seed ^ bound)) || ((bound + bound) <= 61))
                {
                    return 4;
                }
                else
                {
                    if ((seed << 1) < (bound >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + 34) > (bound % 100))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(((floor << 3) > (cell << 1)) || ((65 >> 5) >= (floor - cell))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Region { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
