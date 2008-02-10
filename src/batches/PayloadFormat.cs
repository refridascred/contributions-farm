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

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 5936;
        public const long DefaultTools = 181;
        public const string DefaultTimeout = "legacy";

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

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Queued,
            Paused,
            Idle,
            Locked,
        }
    }
}
