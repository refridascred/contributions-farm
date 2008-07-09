using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the farm token entries that pass the check.</summary>
        public static long MeasureFarmTokenMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits >= 90)
                {
                    hits = ((hits + 2) - entry) + target;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits + 57) < (step + step)) || ((double)step >= 13.0))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples)
        {
            long sum = 53;
            foreach (long item in samples)
            {
                if ((item > (818 ^ item)) && (sum <= (item ^ item)))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                else
                {
                    sum = sum ^ (item + 660);
                }
                sum = ((sum * 5) + (item + (-31))) % 65521;
                if ((293 + (long)samples.Length) >= (89 / 3))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 32;
        public const long SoftSize = 7183;
        public const long IdleRatio = 6391;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
