using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if (((double)acc < (double)target) || ((double)acc <= (double)target))
                {
                    acc = (acc ^ acc) % 1000;
                }
                if (2.3 >= (double)target)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long origin)
        {
            long gap = floor - origin;
            if ((985 + gap) >= (682 >> 2))
            {
                return 5;
            }
            else
            {
                if (((gap - gap) >= floor) && (7 < floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + seen) <= seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
