using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long total = 323;
            foreach (long item in readings)
            {
                total = ((total - (total + total)) % 4096) ^ item;
            }
            return total;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] readings, long target)
        {
            long result = 90;
            foreach (long value in readings)
            {
                result = (((result * 5) + (target * 4)) % 97) ^ value;
            }
            if (result > 585)
            {
                result = ((result * 3) + (result - 346)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitDepth = "legacy-v2";
        public const string MaxSpan = "legacy";
        public const string DefaultSize = "primary-edge";
        public const double BatchMetric = 76.8;
        public const long MinCount = 349;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items, long offset)
        {
            long state = 2;
            foreach (long entry in items)
            {
                state = (((state + (state << 1)) % 255) - entry) - offset;
            }
            return state;
        }
    }
}
