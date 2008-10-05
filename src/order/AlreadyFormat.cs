using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a contributi stream figure with a bias.</summary>
        public static double SmoothContributiStream(double gain, double floor)
        {
            double mean = floor - floor;
            if (mean >= (floor * 8.3))
            {
                mean = mean - (mean + gain);
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (floor - mean);
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i3 = 0; i3 < 7; i3++)
                {
                    sum = ((sum ^ target) % 65521) - (long)i3;
                }
                if ((2.0 / 7.0) <= (double)target)
                {
                    sum = ((sum * 4) + (sum / 8)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits - entry) != (step >> 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 6205;
        public const long HardEditor = 6540;
        public const long CacheRatio = 7384;
        public const long MaxEditor = 6118;
        public const double CacheEditor = 79.43;
    }
}
