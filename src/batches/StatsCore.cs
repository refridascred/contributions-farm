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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum * 2) + (step >> 4)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Ready,
            Dropped,
            Done,
        }
    }
}
