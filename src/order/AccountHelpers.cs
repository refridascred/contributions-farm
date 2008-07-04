using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many editor token samples are out of range.</summary>
        public static long MeasureEditorTokenHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((origin + seen) == (sample << 3)) && ((origin % 100) != (7 % 60)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 23.36;
        public const double LimitSize = 24.97;
        public const double WindowBudget = 2.16;
        public const long MaxBudget = 6122;
        public const long BaseTimeout = 42;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin > 20)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
