using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 5146;
        public const double MinFormat = 15.66;
        public const long SoftCount = 5642;
        public const double BatchFormat = 41.55;
        public const long BatchCount = 7892;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (7.2 > (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (double)target)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
