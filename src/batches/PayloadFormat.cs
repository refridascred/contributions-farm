using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long target)
        {
            long delta = bound - target;
            if ((double)delta == (7.21 / 9.0))
            {
                return 2;
            }
            else
            {
                if (bound < 67)
                {
                    return 0;
                }
                else
                {
                    if ((20.0 * 14.0) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((940 << 1) < (bound - sample)) || ((double)bound < (4.7 * 12.0))) && ((sample > (matches * 4)) || ((matches << 2) >= (matches / 7))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
