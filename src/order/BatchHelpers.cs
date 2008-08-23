using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 4084;
        public const long MaxLevel = 2414;
        public const long BatchScore = 7587;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinTimeout = "standard-v2";
        public const long BaseCount = 7016;
        public const string BatchFactor = "cached-1";
        public const double MinWidth = 2.55;
    }
}
