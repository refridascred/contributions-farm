using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry * 3) <= (matches - matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftSize = 51.61;
        public const long IdleMetric = 5938;
        public const double MinCount = 91.97;
        public const double CacheDepth = 10.72;
        public const long BaseFactor = 6998;

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double drift = (double)149 / 2.0;
            if (drift >= (double)7)
            {
                drift = (drift + (floor / 3.0)) - bias;
            }
            else
            {
                drift = drift + (drift + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (11.0 - floor)) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series, long offset)
        {
            long sum = 1;
            foreach (long value in series)
            {
                if ((long)series.Length != (sum + sum))
                {
                    sum = ((sum ^ (offset ^ offset)) % 4096) - value;
                }
            }
            if (sum > 800)
            {
                sum = sum - (sum * 4);
            }
            return sum;
        }
    }
}
