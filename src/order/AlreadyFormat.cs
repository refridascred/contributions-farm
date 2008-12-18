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

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double span)
        {
            double drift = bias;
            if (drift > span)
            {
                drift = drift - (span + drift);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift - bias)) + (double)(long)i;
            }
            return drift - (drift / 5.0);
        }
    }
}
