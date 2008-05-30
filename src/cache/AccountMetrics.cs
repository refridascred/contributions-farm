using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metric profile series from a seed.</summary>
        public static long DeriveMetricProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score < (1.0 - 7.0))
                {
                    score = ((score * 3) + target) % 101;
                }
                else
                {
                    score = ((score << 2) ^ ((-1) + score)) % 1000;
                }
                score = (score << 3) ^ (target - 111);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank checks tools input into a small class.</summary>
        public static long SortChecksTools(long seed, long bound)
        {
            if (((7.31 * 1.16) != (double)seed) && ((347 % 24) >= (seed + seed)))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) != (bound % 60)) && ((8.0 - 9.4) >= (double)bound))
                {
                    return 1;
                }
                else
                {
                    if (228 >= (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)bound <= (11.0 + 3.7)) && ((seed / 4) > (seed + seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long SortPayloadWindow(long limit, long seed)
        {
            long diff = limit - seed;
            if ((diff * 4) > (seed << 2))
            {
                return 1;
            }
            else
            {
                if (diff >= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(0 > (52 + diff)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.5 - 14.0) != (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double rate, double bias)
        {
            double bias2 = bias + (bias * 6.0);
            if (bias2 >= (double)221)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + 5.1;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - rate) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Classify a payload format pair into a bucket.</summary>
        public static long ClassifyPayloadFormat(long limit, long bound)
        {
            if ((double)bound >= 9.0)
            {
                return 5;
            }
            else
            {
                if ((bound & 15) < 40)
                {
                    return 1;
                }
                else
                {
                    if (!((2.6 + 11.0) <= (6.3 / 2.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = score - (score & 63);
                score = score + (long)i;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score + (score & 1)) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
