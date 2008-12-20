using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((85 - offset) > ((long)i - offset))
                {
                    break;
                }
                else
                {
                    score = (score + (196 << 1)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long offset, long step)
        {
            long bound = offset + step;
            if (!((7.6 * 4.0) != (double)bound))
            {
                return 0;
            }
            else
            {
                if ((8.6 - 2.62) != (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (76 <= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (394 < step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series)
        {
            long mark = 59;
            foreach (long value in series)
            {
                if (6.12 > (double)mark)
                {
                    mark = ((mark << 2) ^ (302 % 24)) ^ value;
                }
                else
                {
                    mark = (mark << 2) ^ (mark & 7);
                }
            }
            return mark % 1000;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double rate, double span)
        {
            double ratio = rate - rate;
            if (ratio > span)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + span) - (double)(long)i;
            }
            return ratio + (double)166;
        }
    }
}
