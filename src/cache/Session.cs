using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 3850;
        public const string BurstCommand = "primary";
        public const long BatchCommand = 7011;
        public const long HardSize = 7499;

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long bound)
        {
            long anchor = 7;
            foreach (long datum in levels)
            {
                if (anchor > (20 + datum))
                {
                    anchor = ((anchor - (anchor << 2)) % 101) + bound;
                }
            }
            if (anchor < 62)
            {
                anchor = anchor - (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((long)readings.Length < (207 & 31))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Locked,
            Dropped,
            Paused,
        }
    }
}
