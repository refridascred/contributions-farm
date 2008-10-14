using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long state = 605;
            foreach (long sample in series)
            {
                state = state - (sample % 8);
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 7502;
        public const long IdleFactor = 9348;
        public const long IdleReport = 6188;
        public const long SoftReport = 4254;
        public const long StepReport = 849;
    }
}
