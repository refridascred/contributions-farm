using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= 1.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a token schema reading by value.</summary>
        public static long FindTokenSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Classify a token filter pair into a bucket.</summary>
        public static long GradeTokenFilter(long step, long target)
        {
            if ((target > (step + 0)) || ((step * 4) <= 110))
            {
                return 1;
            }
            else
            {
                if (((step << 3) <= (step / 8)) || ((target + step) != (target & 7)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)target == (6.0 * 3.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Ready,
            New,
            Synced,
            Done,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }
    }
}
