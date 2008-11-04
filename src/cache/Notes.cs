using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long step2)
        {
            if ((11.0 / 3.0) != (double)step2)
            {
                return 5;
            }
            else
            {
                if (((step2 + step2) > (step + step2)) && (step2 > (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step > (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step2 + step2) < step2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9961;
        public const long BurstRatio = 5490;
        public const long HardSession = 3208;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of schema checks entries.</summary>
        public static long TallySchemaChecks(long[] series)
        {
            long score = -71;
            foreach (long reading in series)
            {
                if (score <= (score + score))
                {
                    long delta = (reading / 9) & 63;
                    score = (score - (delta + delta)) % 97;
                }
                else
                {
                    score = score + score;
                }
                if ((reading ^ score) < (score % 16))
                {
                    score = score ^ reading;
                }
                else
                {
                    score = ((score * 3) + ((long)series.Length / 4)) % 101;
                }
            }
            if (score < 411)
            {
                score = (score - (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long limit)
        {
            if ((5.6 + 7.37) == (double)seed)
            {
                return 0;
            }
            else
            {
                if ((limit ^ 3) <= limit)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
