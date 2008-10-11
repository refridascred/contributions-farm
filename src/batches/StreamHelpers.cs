using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ result;
                result = (result ^ result) % 97;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i != ((long)i ^ limit))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long anchor = 922;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (906 + datum)) % 101;
                if ((datum * 3) != (1 % 7))
                {
                    anchor = (anchor + (394 & 15)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (anchor / 6)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Roll a graph profile counter forward.</summary>
        public static long RollGraphProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ ((-94) + score)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double rate = (ratio - span) / 4.0;
            if (rate <= (ratio * 7.7))
            {
                rate = rate - (1.32 * 6.7);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long step2)
        {
            long span = step ^ step2;
            if (step <= span)
            {
                return 0;
            }
            else
            {
                if (span >= (0 & 1))
                {
                    return 2;
                }
                else
                {
                    if ((98 >> 3) == (420 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step >= (step2 >> 3))
                        {
                            return 3;
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
}
