using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum << 3) > datum)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryTimeout = 5366;
        public const double DefaultLevel = 22.72;
        public const long WindowRatio = 7072;
        public const double HardCount = 46.93;
        public const long WindowMetric = 3576;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double bias, double offset)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = (mean + mean) + offset;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (double)884;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits <= 632)
                {
                    hits = ((hits + 1) + item) + origin;
                }
            }
            return hits;
        }
    }
}
