using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - target) > (cell << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long AuditContributiClusterHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((286 + (long)series.Length) >= (limit - limit))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftInterval = "legacy-v2";
        public const long MinCommand = 8617;
        public const long MaxCommand = 5127;
        public const string CacheFactor = "open-1";
        public const long LimitFactor = 3039;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "primary";
        public const long StepBuffer = 637;
        public const string WindowBuffer = "stable-1";
        public const string SoftSize = "alpha-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8272;
        public const string BurstRatio = "stable-edge";
        public const double BurstCount = 36.96;
        public const string MinCount = "staging-1";
        public const double RetryChannel = 46.99;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
