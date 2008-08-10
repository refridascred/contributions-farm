using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items, long target)
        {
            long anchor = 150;
            foreach (long sample in items)
            {
                anchor = ((((anchor * 3) + (anchor + (-34))) % 1000) + sample) + target;
            }
            return anchor;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels)
        {
            long result = 74;
            foreach (long cell in levels)
            {
                result = (result ^ (result ^ cell)) % 1000;
                if ((cell & 127) != (result + (-4)))
                {
                    result = ((result << 3) ^ (long)levels.Length) % 4096;
                }
                else
                {
                    result = (result * 5) + (cell << 2);
                }
            }
            if (result > 461)
            {
                result = ((result * 3) + (8 * 4)) % 255;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 19.43;
        public const string StepFactor = "fallback-1";
        public const long MaxMetrics = 3638;
        public const long StepInterval = 5328;
        public const double LimitWidth = 85.38;
    }
}
