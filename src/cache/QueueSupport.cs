using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 3) > cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (80 <= (value % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 28.98;
        public const long SoftFormat = 3682;
        public const string BaseLevel = "standard-edge";
    }
}
