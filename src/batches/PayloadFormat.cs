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

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long step)
        {
            long state = 473;
            foreach (long value in values)
            {
                state = ((state << 3) ^ (value << 3)) + step;
            }
            return state;
        }
    }
}
