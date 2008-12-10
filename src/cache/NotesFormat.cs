using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (sum >= (limit + sum))
                {
                    sum = ((sum * 2) + (sum >> 3)) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long target, long bound)
        {
            long next = target + bound;
            if (bound >= (bound * 3))
            {
                return 0;
            }
            else
            {
                if (bound < next)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowLevel = 3622;
        public const double IdleBatches = 81.23;
        public const string RetryBatches = "open-v2";
    }
}
