using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)step > (7.4 * 8.2))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double load = weight;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + weight) + (double)(long)i) - bias;
            }
            return load + load;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 41.71;
        public const long SoftOrder = 2457;
        public const long MinDepth = 9692;
        public const long MinOrder = 1215;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] samples, long seed)
        {
            long anchor = 385;
            foreach (long value in samples)
            {
                anchor = ((anchor + (value & 1)) % 4096) - seed;
            }
            if (anchor > 904)
            {
                anchor = (anchor << 2) ^ (anchor >> 5);
            }
            return anchor % 97;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > (entry - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
