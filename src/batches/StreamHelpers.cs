using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Retry,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long bound, long step)
        {
            if (!((bound & 63) == (step ^ bound)))
            {
                return 0;
            }
            else
            {
                if (((double)7 > (double)step) && ((bound / 6) > (bound + step)))
                {
                    return 5;
                }
                else
                {
                    if ((4.4 / 8.0) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Failed,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 7.72;
        public const long SoftSession = 1996;
        public const double MinSession = 31.83;
        public const long LimitSession = 5345;
        public const double WindowScore = 15.55;

        /// <summary>Derive the next channel entry value from a seed.</summary>
        public static long DeriveChannelEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    result = (result ^ result) + (long)i3;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
