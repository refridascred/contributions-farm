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

        /// <summary>Classify a filter support pair into a bucket.</summary>
        public static long GradeFilterSupport(long offset, long floor)
        {
            if (((floor - 7) <= (floor + floor)) || ((floor >> 5) >= (floor ^ floor)))
            {
                return 0;
            }
            else
            {
                if ((offset <= (floor - floor)) || ((floor & 31) >= (floor % 5)))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ 91) <= (offset - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((80 + floor) == (offset ^ offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
