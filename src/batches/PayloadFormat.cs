using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftCount = "strict-edge";
        public const string LimitEntry = "cached-v2";
        public const long HardDepth = 9705;
        public const long WindowTimeout = 4256;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels, long step)
        {
            long score = 0;
            foreach (long sample in levels)
            {
                score = (score ^ (sample << 1)) - step;
            }
            if (score > 3)
            {
                score = (score - 2) % 4096;
            }
            return score % 1000;
        }
    }
}
