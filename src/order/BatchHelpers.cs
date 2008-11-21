using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score << 3) ^ (step + 514);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 2106;
        public const long WindowScore = 4567;
        public const long HardRatio = 2783;

        /// <summary>Validate session order readings against a bound.</summary>
        public static bool VerifySessionOrderBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
