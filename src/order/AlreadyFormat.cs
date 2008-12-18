using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Active,
            Retry,
            Done,
            Closed,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double span)
        {
            double gain2 = span / 7.0;
            return (gain2 + (double)(-2)) + gain;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= 2.9)
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

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = (double)81 * 0.55;
            if (scale < scale)
            {
                scale = (scale + (span * 15.0)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale + (scale * 11.0);
        }
    }
}
