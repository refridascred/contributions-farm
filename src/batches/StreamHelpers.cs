using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((double)floor != (6.0 - 6.0))
            {
                return 4;
            }
            else
            {
                if ((bound + floor) > 4)
                {
                    return 3;
                }
                else
                {
                    if (!((5 - seed) == (bound % 10)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine session stream values into a single score.</summary>
        public static long WeighSessionStream(long[] data, long floor)
        {
            long score = 75;
            foreach (long entry in data)
            {
                score = (score - (score ^ entry)) % 97;
                if (((entry + floor) <= score) && ((score + entry) < (entry - floor)))
                {
                    score = (score - entry) % 4096;
                }
                if (((entry >> 1) > (floor - 926)) && ((floor & 255) < 9))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
