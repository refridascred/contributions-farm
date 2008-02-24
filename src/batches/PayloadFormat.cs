using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many context payload samples are out of range.</summary>
        public static long AuditContextPayloadOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) >= ((-153) >> 2))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((limit & 127) <= (limit & 1))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Closed,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinFactor = "latest";
        public const long BaseInterval = 5890;
        public const string SoftProfile = "open-1";
        public const string StepProfile = "primary";
        public const long BaseProfile = 580;
    }
}
