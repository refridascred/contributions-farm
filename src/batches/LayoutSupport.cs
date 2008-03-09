using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double weight, double span)
        {
            double ratio = weight;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)(long)i) + span;
            }
            return ratio + (ratio + ratio);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1672;
        public const double WindowWidth = 28.31;
        public const long BurstAccount = 4999;
        public const double BaseAccount = 26.42;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long origin, long bound)
        {
            if ((double)origin < (0.4 / 4.0))
            {
                return 0;
            }
            else
            {
                if (!((origin * 3) <= origin))
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ origin) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank session tools input into a small class.</summary>
        public static long GradeSessionTools(long floor, long bound)
        {
            long slot = floor ^ bound;
            if ((double)bound >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((bound * 3) <= (slot << 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length != (8.2 - 6.0))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
