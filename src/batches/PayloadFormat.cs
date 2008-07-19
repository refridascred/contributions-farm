using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Ready,
            Locked,
            New,
            Paused,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            if (!(seed <= (987 % 60)))
            {
                return 2;
            }
            else
            {
                if ((9.7 / 6.0) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a token queue sample.</summary>
        public static long SeekTokenQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
