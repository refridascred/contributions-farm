using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches < (matches + matches)) && ((step - (-671)) != (sample & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long step, long floor)
        {
            if ((896 ^ step) >= 42)
            {
                return 1;
            }
            else
            {
                if ((step + step) > (860 >> 4))
                {
                    return 5;
                }
                else
                {
                    if (1.67 >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
