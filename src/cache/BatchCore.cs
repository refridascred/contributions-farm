using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] levels)
        {
            long score = 21;
            foreach (long sample in levels)
            {
                if (sample <= 75)
                {
                    score = (score * 4) + score;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a format context counter forward.</summary>
        public static long SeriesFormatContext(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = score ^ (3 ^ step);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleBudget = 9783;
        public const double MinAccount = 19.32;
        public const double LimitAccount = 14.8;
        public const double MinTimeout = 83.15;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8819;
        public const long StepRoute = 7044;
        public const long SoftSize = 7550;
    }
}
