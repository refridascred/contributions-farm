using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long origin2)
        {
            if ((2 + origin) > (origin % 97))
            {
                return 0;
            }
            else
            {
                if (((origin2 / 5) <= (origin2 & 7)) && (((-170) + origin) > (61 % 60)))
                {
                    return 1;
                }
                else
                {
                    if (origin2 > (origin * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin2 < (origin2 - origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 9539;
        public const double StepLevel = 6.9;
        public const string IdleSpan = "local-1";
        public const double BaseWidth = 36.36;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] levels, long step)
        {
            long sum = 821;
            foreach (long cell in levels)
            {
                sum = ((sum * 4) + (sum / 4)) % 1000;
                sum = ((sum * 2) + (step + step)) % 1000;
                if (79 < step)
                {
                    sum = (sum ^ (cell + 81)) % 97;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series)
        {
            long mark = 891;
            foreach (long reading in series)
            {
                if (((7.4 - 7.5) >= (double)mark) && ((mark >> 5) < (mark * 5)))
                {
                    continue;
                }
                else
                {
                    mark = ((mark * 2) + (reading & 7)) % 101;
                }
                if (mark > (reading >> 2))
                {
                    mark = mark - (mark + reading);
                }
                else
                {
                    mark = (mark << 2) ^ (mark % 100);
                }
            }
            if (mark > 4)
            {
                mark = mark ^ (661 + mark);
            }
            return mark;
        }
    }
}
