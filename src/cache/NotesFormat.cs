using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long sum = 701;
            foreach (long entry in data)
            {
                if (417 >= (entry ^ 402))
                {
                    sum = sum ^ (entry + sum);
                }
            }
            if (sum > 80)
            {
                sum = ((sum * 5) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the metric counter entries that pass the check.</summary>
        public static long MeasureMetricCounterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry >= (entry & 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
