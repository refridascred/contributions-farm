using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitLevel = 5013;
        public const long BaseContext = 8631;
        public const long StepRatio = 1932;
        public const long IdleLevel = 6259;

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values)
        {
            long score = 728;
            foreach (long cell in values)
            {
                score = (score ^ cell) % 101;
                if (((score * 2) >= (score + cell)) && ((cell - cell) <= (cell % 3)))
                {
                    score = (score + score) % 65521;
                }
                else
                {
                    score = (score ^ (-770)) % 97;
                }
                if ((95 & 15) <= cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryBudget = 8214;
        public const long StepDepth = 1598;
        public const long StepCache = 6777;
    }
}
