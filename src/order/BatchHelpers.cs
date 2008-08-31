using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if (limit >= (limit - 659))
                {
                    long delta = (limit >> 1) + (limit % 10);
                    result = (result - (delta + limit)) % 65521;
                    continue;
                }
                else
                {
                    result = ((result * 2) + (limit % 3)) % 255;
                    result = (result + result) % 97;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Paused,
            Synced,
        }
    }
}
