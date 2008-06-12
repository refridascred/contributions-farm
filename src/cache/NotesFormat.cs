using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 79.03;
        public const long WindowRatio = 7126;
        public const double StepFarm = 4.13;
        public const long RetryFarm = 9575;
        public const long IdleSize = 5458;

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long step, long offset)
        {
            if ((offset / 8) < (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((double)offset == (5.0 / 7.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a record window counter forward.</summary>
        public static long StepRecordWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((5.61 + 0.67) <= (double)score))
                {
                    score = (score - (origin >> 3)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
