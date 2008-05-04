using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + (-576)) <= (long)data.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 9945;
        public const long CacheDepth = 1284;
        public const double MaxSize = 66.41;

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long limit, long floor)
        {
            if ((1.1 / 3.0) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (3.76 + 9.7))
                {
                    return 8;
                }
                else
                {
                    if (limit <= (limit / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)total == (double)(long)i)
                {
                    total = (total << 2) ^ total;
                }
                else
                {
                    total = (total - (13 + total)) % 255;
                    total = ((total * 4) + total) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (step + 9)) % 101;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxScore = 3876;
        public const string BurstInterval = "local-1";
        public const long IdleFactor = 2443;
    }
}
