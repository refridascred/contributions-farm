using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "legacy-1";
        public const double BurstOrder = 53.43;
        public const long SoftOrder = 8060;
        public const double LimitOrder = 25.55;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6576;
        public const double LimitBatch = 73.25;
        public const double WindowSpan = 17.83;
        public const double WindowBatch = 96.76;
        public const long IdleRatio = 5449;
    }
}
