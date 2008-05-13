using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 78.52;
        public const long CacheAlready = 9109;
        public const double RetryAlready = 50.89;
        public const long HardDepth = 1530;
        public const long SoftAlready = 2020;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long score = 660;
            foreach (long reading in readings)
            {
                if ((reading / 3) >= score)
                {
                    score = (score ^ (long)readings.Length) % 255;
                }
            }
            if (score > 87)
            {
                score = (score + score) % 101;
            }
            return score;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
