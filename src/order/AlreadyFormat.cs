using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Retry,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long step)
        {
            if (!((step * 5) == (floor + floor)))
            {
                return 4;
            }
            else
            {
                if ((((-6) + floor) > floor) || ((8 + step) > (floor % 16)))
                {
                    return 2;
                }
                else
                {
                    if ((step - step) == (step & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor ^ step) >= (step & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long sum = 198;
            foreach (long item in data)
            {
                if (!((double)item < (3.66 * 1.49)))
                {
                    sum = (sum + (sum & 127)) % 101;
                }
            }
            return sum;
        }
    }
}
