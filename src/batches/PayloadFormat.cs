using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= seen)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Project the next support order value.</summary>
        public static double ProjectSupportOrder(double scale, double offset)
        {
            double rate = 3.5;
            if (rate < (scale / 7.0))
            {
                rate = (rate - (rate / 5.0)) - offset;
            }
            else
            {
                rate = rate - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + scale) - (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((696 - datum) >= (long)series.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
