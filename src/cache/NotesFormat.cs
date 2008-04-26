using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine layout session values into a single score.</summary>
        public static long CombineLayoutSession(long[] levels)
        {
            long score = 65;
            foreach (long datum in levels)
            {
                if ((datum + datum) >= 357)
                {
                    score = (score ^ (score - score)) % 97;
                }
            }
            if (score < 46)
            {
                score = (score * 2) + ((-7) << 1);
            }
            return score % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry < (entry & 7)) && ((entry + entry) < entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double bias = (double)(175 & 1);
            if (bias > span)
            {
                bias = bias + weight;
            }
            return bias + weight;
        }
    }
}
