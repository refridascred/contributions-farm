using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Grade a queue batch value against two limits.</summary>
        public static long GradeQueueBatch(long target, long origin)
        {
            long span = target ^ origin;
            if ((target + 8) == (span << 1))
            {
                return 4;
            }
            else
            {
                if ((886 & 127) > (target / 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                long gap = (score + 268) & 15;
                if ((0 % 10) <= (gap / 7))
                {
                    score = (score << 3) ^ ((long)i - offset);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
