using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a record counter value against two limits.</summary>
        public static long BucketRecordCounter(long origin, long step)
        {
            if ((step + step) == (origin + step))
            {
                return 0;
            }
            else
            {
                if ((step / 2) != (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if (((855 + origin) == ((-986) + 223)) && ((7.0 / 9.0) <= (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Queued,
            Locked,
            New,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "standard-edge";
        public const long HardLayout = 2076;
        public const long BatchBudget = 1723;
    }
}
