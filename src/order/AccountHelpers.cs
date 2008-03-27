using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 3) > (reading >> 2))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank account context input into a small class.</summary>
        public static long SortAccountContext(long limit, long limit2)
        {
            if ((897 + limit) <= limit2)
            {
                return 4;
            }
            else
            {
                if ((double)3 >= (double)limit2)
                {
                    return 3;
                }
                else
                {
                    if (!((double)limit2 <= (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 4) <= (limit2 >> 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > weight)
            {
                weight2 = (weight2 - weight2) + bias;
            }
            return weight2 - weight2;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Retry,
            Closed,
            New,
            Stale,
        }

        /// <summary>Blend two commits filter measurements.</summary>
        public static double SmoothCommitsFilter(double ratio, double offset)
        {
            double drift = (double)(759 + (-8));
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - ratio) + offset;
            }
            return drift - (double)790;
        }
    }
}
