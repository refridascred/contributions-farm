using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Synced,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double weight = (double)400;
            if (weight < (double)39)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 6.0) + (double)(long)i;
            }
            return weight + (scale + scale);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long anchor = 45;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 2) ^ (anchor & 255)) % 101) ^ sample;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (8.0 * 1.0))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }
    }
}
