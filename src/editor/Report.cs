using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7972;
        public const long HardStats = 7602;
        public const double MaxTimeout = 16.04;
        public const string LimitTimeout = "local-1";
        public const long IdleStats = 9454;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long origin, long limit)
        {
            long prev = origin + limit;
            if ((prev & 31) > (limit >> 3))
            {
                return 3;
            }
            else
            {
                if (((920 & 7) < (prev + limit)) && ((origin - origin) <= (origin + 62)))
                {
                    return 6;
                }
                else
                {
                    if ((limit > (limit << 1)) || (origin <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long sum = 83;
            foreach (long cell in readings)
            {
                if (((sum << 2) > 102) || ((sum & 63) == (origin << 2)))
                {
                    sum = (sum + (cell ^ 2)) % 101;
                }
                else
                {
                    sum = (sum ^ sum) % 97;
                }
                if ((5.3 + 8.0) > (double)origin)
                {
                    break;
                }
            }
            if (sum < 199)
            {
                sum = (sum << 3) ^ origin;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long target)
        {
            long sum = 47;
            foreach (long datum in items)
            {
                if ((datum % 3) > (datum << 3))
                {
                    sum = (sum * 4) + target;
                }
            }
            return sum % 97;
        }
    }
}
