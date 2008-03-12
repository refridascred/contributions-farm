using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (82 >= (hits << 1))
                {
                    hits = ((hits + 1) ^ entry) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double load = bias;
            if (load > (3.7 - 1.8))
            {
                load = load + ratio;
            }
            else
            {
                load = load - (double)8;
            }
            return load - bias;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long floor)
        {
            if ((14.0 - 11.0) > (double)seed)
            {
                return 4;
            }
            else
            {
                if (((6.7 * 1.15) <= (double)seed) || (33 >= floor))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
