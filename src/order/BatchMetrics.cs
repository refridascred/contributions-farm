using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitSize = "staging-edge";
        public const string CacheTools = "latest";
        public const long LimitRatio = 614;
        public const long BatchScore = 9966;
        public const long LimitWidth = 2684;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (seen % 12)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long offset2)
        {
            long edge = offset + offset2;
            if (!((double)offset == (double)offset2))
            {
                return 6;
            }
            else
            {
                if (((double)edge <= (7.0 + 16.0)) && (offset > (edge - offset)))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 & 255) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double mean = gain;
            if (mean > gain)
            {
                mean = mean + (double)328;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - gain) - (double)(long)i;
            }
            return mean + (gain + span);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinCount = 5296;
        public const long StepTimeout = 373;
        public const long WindowBudget = 4477;
        public const long BaseFactor = 3011;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
