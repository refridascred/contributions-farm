using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long offset)
        {
            if ((bound << 2) >= (offset >> 1))
            {
                return 0;
            }
            else
            {
                if (7.5 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((limit ^ total) < (total ^ 344)))
                {
                    total = ((total << 3) ^ (total + limit)) % 4096;
                    total = (total - ((long)i % 60)) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetryInterval = 37.24;
        public const string StepSupport = "open-1";
        public const long SoftSupport = 7482;
    }
}
