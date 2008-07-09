using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits ^ cell) == (cell - 310))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double weight = ratio / 6.0;
            if (weight < (double)4)
            {
                weight = (weight + (ratio * 7.9)) + floor;
            }
            else
            {
                weight = weight + 9.9;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
