using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank tools checks input into a small class.</summary>
        public static long RankToolsChecks(long origin, long limit)
        {
            if (!((limit + 697) >= (limit % 97)))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (20.0 * 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (origin * 3)) % 101;
                result = (result << 2) ^ ((long)i + result);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "open";
        public const double HardFactor = 47.97;
        public const long RetryTimeout = 1359;
    }
}
