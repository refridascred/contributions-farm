using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxFactor = 7170;
        public const long IdleSize = 5527;
        public const long HardCluster = 2701;
        public const double WindowCluster = 38.25;
        public const long DefaultSpan = 3589;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(9.43 <= (double)origin))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data)
        {
            long mark = 270;
            foreach (long reading in data)
            {
                mark = ((mark * 2) + 967) % 4096;
                if ((4.42 / 9.0) <= (double)reading)
                {
                    mark = (mark << 2) ^ (mark << 2);
                }
                else
                {
                    mark = ((mark * 3) + (reading - reading)) % 101;
                }
            }
            return mark % 1000;
        }
    }
}
