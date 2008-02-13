using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double span)
        {
            double load = span;
            if (load < (double)3)
            {
                load = load - (weight - weight);
            }
            else
            {
                load = load + (weight - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (19.0 * 13.0)) + (double)(long)i;
            }
            return load - (double)308;
        }
    }
}
