using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Synced,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples, long limit)
        {
            long state = 91;
            foreach (long reading in samples)
            {
                if ((1.0 - 3.77) != (double)limit)
                {
                    state = (((state << 3) ^ limit) % 101) - reading;
                }
                if (3 <= (limit - (-54)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Failed,
            Idle,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long bound, long step)
        {
            long edge = bound - step;
            if (bound <= (edge & 63))
            {
                return 0;
            }
            else
            {
                if (0 >= (bound / 4))
                {
                    return 6;
                }
                else
                {
                    if ((20 ^ step) <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
