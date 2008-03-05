using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            if ((floor >> 4) != (floor >> 5))
            {
                return 8;
            }
            else
            {
                if ((target / 7) >= target)
                {
                    return 1;
                }
                else
                {
                    if (floor < (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double scale = (double)0 / 6.0;
            return (scale - (weight - weight)) + offset;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) >= (seed + 8)) && (seed < (reading >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
