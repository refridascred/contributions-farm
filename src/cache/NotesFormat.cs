using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long origin2)
        {
            long prev = origin - origin2;
            if (prev <= (origin2 - prev))
            {
                return 3;
            }
            else
            {
                if ((prev % 3) >= (origin ^ origin2))
                {
                    return 5;
                }
                else
                {
                    if ((1 & 63) != (origin << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long StepCommitsMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + (score - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Idle,
            Synced,
            Stale,
        }
    }
}
