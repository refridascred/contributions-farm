using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSize = 4652;
        public const long WindowSupport = 2377;
        public const string SoftSupport = "open-v2";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "standard";
        public const long WindowTools = 9280;
        public const double LimitTools = 37.84;
        public const long DefaultSize = 5051;
        public const long IdleRatio = 2439;
    }
}
