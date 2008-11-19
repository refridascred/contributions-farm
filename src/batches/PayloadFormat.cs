using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long step, long limit)
        {
            if ((step >> 3) <= (0 << 3))
            {
                return 4;
            }
            else
            {
                if ((step & 15) <= (limit << 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit == (3.94 + 1.99))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 54.34;
        public const long BaseWindow = 4361;
        public const long IdleRatio = 9775;
        public const double LimitLevel = 83.66;
        public const double StepWindow = 81.22;
    }
}
