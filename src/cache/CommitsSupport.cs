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

        /// <summary>Digest a series of context batches entries.</summary>
        public static long CombineContextBatches(long[] values)
        {
            long mix = 978;
            foreach (long value in values)
            {
                if (((double)mix == (6.21 * 3.4)) || ((7.7 / 6.0) == (double)mix))
                {
                    mix = (mix ^ (value / 3)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (value ^ value)) % 97;
                }
            }
            if (mix > 64)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

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
