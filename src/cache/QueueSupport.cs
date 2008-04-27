using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseSpan = 6941;
        public const long BatchCount = 2010;
        public const long IdleRoute = 5647;
        public const string BurstRoute = "alpha";
        public const long SoftRoute = 1605;

        /// <summary>Audit context metrics readings against a rule.</summary>
        public static long AuditContextMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + matches) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item / 2) <= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
