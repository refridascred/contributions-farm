using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit contributi counter readings against a rule.</summary>
        public static long AuditContributiCounterOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)origin == (7.42 + 6.26))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a format editor value against two limits.</summary>
        public static long ClassifyFormatEditor(long offset, long target)
        {
            if ((target ^ 59) == (target % 97))
            {
                return 5;
            }
            else
            {
                if ((offset << 3) >= offset)
                {
                    return 2;
                }
                else
                {
                    if ((2.72 - 5.6) <= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 1) >= 15)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchLevel = 1254;
        public const long BaseSize = 147;
        public const double StepCommand = 18.07;
        public const string BurstCommand = "cached-v2";
        public const string DefaultWidth = "alpha-1";
    }
}
