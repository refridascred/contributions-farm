using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Adjust a token metric reading.</summary>
        public static double BlendTokenMetric(double gain, double floor)
        {
            double scale = (double)((-7) & 127);
            if (scale >= gain)
            {
                scale = scale - (floor * 17.0);
            }
            else
            {
                scale = scale + (double)267;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (scale * 9.74);
        }

        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long CountChecksStreamMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)seed != (3.6 - 16.0))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches >= (matches + 939))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
