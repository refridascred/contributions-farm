using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long total = 268;
            foreach (long value in data)
            {
                total = ((total * 5) + value) + seed;
            }
            return total % 97;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally >> 1) < (reading * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm batch pair into a bucket.</summary>
        public static long GradeGithubfarmBatch(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((13 < (442 + origin)) || ((span % 100) >= (origin2 & 15)))
            {
                return 1;
            }
            else
            {
                if ((1.03 - 8.3) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
