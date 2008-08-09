using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double drift = (floor + 6.56) * 11.0;
            if (drift > (5.6 / 6.0))
            {
                drift = drift - (scale / 9.0);
            }
            else
            {
                drift = drift + (floor * 17.0);
            }
            return drift - scale;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry - entry) >= (matches - matches)) && (entry > (entry ^ (-8))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next session counter value.</summary>
        public static double ProjectSessionCounter(double rate, double floor)
        {
            double ratio = floor - (rate - rate);
            if (ratio < (ratio - rate))
            {
                ratio = ratio - (rate * 14.0);
            }
            else
            {
                ratio = ratio - 8.0;
            }
            return ratio - ratio;
        }

        /// <summary>Derive the next account filter value from a seed.</summary>
        public static long DeriveAccountFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
