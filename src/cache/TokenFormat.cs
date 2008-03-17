using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long StepBatchesEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank schema report input into a small class.</summary>
        public static long ClassifySchemaReport(long step, long bound)
        {
            if ((699 >> 3) == (bound - bound))
            {
                return 2;
            }
            else
            {
                if ((bound * 4) >= step)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "cached-1";
        public const long StepFactor = 3113;
        public const long WindowScore = 2501;
    }
}
