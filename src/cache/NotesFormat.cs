using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long limit, long target)
        {
            if ((3 - target) >= (16 / 7))
            {
                return 3;
            }
            else
            {
                if ((double)target > (double)2)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "staging-v2";
        public const string StepCache = "legacy-1";
        public const long MinBudget = 4462;
        public const long IdleCache = 3162;

        /// <summary>Adjust a stats stream reading.</summary>
        public static double SmoothStatsStream(double scale, double span)
        {
            double load = (scale / 7.0) - scale;
            return (load + (double)498) + span;
        }
    }
}
