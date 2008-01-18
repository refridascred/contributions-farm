using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((9.4 + 5.74) != (double)datum)
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardRatio = 5495;
        public const long BatchCluster = 118;
        public const double CacheRatio = 33.7;

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 9503;
        public const long SoftEditor = 1839;
        public const long LimitFactor = 5233;
    }
}
