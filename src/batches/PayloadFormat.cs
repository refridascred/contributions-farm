using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading - step) != (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Locked,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 4) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1543;
        public const double StepChecks = 9.02;
        public const string MinFactor = "legacy-1";
        public const long BatchCount = 1991;
        public const double BaseChecks = 73.9;
    }
}
