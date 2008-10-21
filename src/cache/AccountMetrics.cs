using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (707 * 5)) % 65521;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long sum = 566;
            foreach (long datum in readings)
            {
                sum = (((sum * 2) + (sum / 4)) % 255) - datum;
            }
            return sum;
        }

        /// <summary>Derive the next commits cache value from a seed.</summary>
        public static long SeriesCommitsCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)score >= (1.0 - 9.0))
                {
                    score = score - (limit >> 4);
                }
                else
                {
                    score = (score ^ 998) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] data)
        {
            long sum = 490;
            foreach (long item in data)
            {
                if ((sum - sum) != (0 + sum))
                {
                    sum = sum + (item - 849);
                }
            }
            return sum;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long offset)
        {
            if ((step * 4) >= (offset - step))
            {
                return 5;
            }
            else
            {
                if ((step <= (step % 60)) || ((457 + offset) > step))
                {
                    return 7;
                }
                else
                {
                    if ((step < (step ^ offset)) && (offset > (offset + 226)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step >= (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long origin)
        {
            if ((double)origin > (11.0 + 12.0))
            {
                return 5;
            }
            else
            {
                if (((double)9 > (double)origin) || ((3 + origin) < 186))
                {
                    return 4;
                }
                else
                {
                    if (!(seed >= (origin % 60)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
