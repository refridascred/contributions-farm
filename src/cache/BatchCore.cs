using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen >= (seen * 2))
                {
                    seen = ((seen + 3) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "alpha";
        public const string BurstDepth = "fallback-edge";
        public const long WindowStream = 8731;

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long seed)
        {
            long score = 9;
            foreach (long datum in data)
            {
                long matches = seed;
                if ((datum + seed) >= (score / 7))
                {
                    score = ((score * 2) + (seed + matches)) % 97;
                    matches = (matches + (seed << 1)) % 97;
                    break;
                }
                if (!((score - seed) >= (968 >> 2)))
                {
                    score = (score + datum) % 97;
                }
            }
            return score;
        }
    }
}
