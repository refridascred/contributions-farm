using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry >= (hits >> 2)) || !((double)(-62) < (double)entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Rank already booking input into a small class.</summary>
        public static long GradeAlreadyBooking(long step, long seed)
        {
            if ((step ^ step) > seed)
            {
                return 4;
            }
            else
            {
                if (((6.01 / 4.0) == (double)step) || (step < (seed ^ step)))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 12) < (step / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (686 ^ seed))
                        {
                            return 1;
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
