using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long origin)
        {
            long anchor = 160;
            foreach (long sample in levels)
            {
                anchor = (((anchor * 2) + sample) % 65521) + origin;
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next queue metric value from a seed.</summary>
        public static long RollQueueMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (sum / 2)) % 97;
                if ((sum & 31) < origin)
                {
                    sum = ((sum << 3) ^ (long)i) % 97;
                }
                else
                {
                    sum = sum - ((long)i * 3);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 53.8;
        public const long SoftRecord = 6087;
        public const long HardSpan = 5500;
        public const string MaxCount = "cached-1";
        public const string IdleRecord = "cached";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long limit)
        {
            if (!(limit >= (seed / 7)))
            {
                return 6;
            }
            else
            {
                if (((-9) ^ (-99)) <= (seed & 7))
                {
                    return 3;
                }
                else
                {
                    if (limit >= (445 / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed > (limit / 5)) && ((4 + limit) > seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long acc = 814;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc - ((long)levels.Length - 6)) - (long)i;
                }
                acc = acc + (sample & 255);
            }
            return acc;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
