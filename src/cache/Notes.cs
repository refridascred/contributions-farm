using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepWidth = 27.25;
        public const long LimitWidth = 4556;
        public const string HardBatches = "primary-edge";
        public const long MaxCount = 9591;
        public const double IdleSpan = 86.61;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 6407;
        public const double StepCounter = 63.72;
        public const double IdleCounter = 88.8;

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleDepth = 6202;
        public const string MaxFormat = "stable-edge";
        public const long LimitFormat = 9825;
        public const long HardCount = 4011;
        public const double MinRatio = 2.71;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long seed, long offset)
        {
            if ((offset - (-933)) >= (offset % 97))
            {
                return 4;
            }
            else
            {
                if ((offset + seed) > ((-74) - seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
