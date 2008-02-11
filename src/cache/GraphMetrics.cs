using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double ratio, double offset)
        {
            double ratio2 = (double)(21 - 9);
            for (int i = 0; i < 7; i++)
            {
                ratio2 = ((ratio2 + offset) + (double)(long)i) - ratio;
            }
            return ratio2 - (ratio2 / 6.0);
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long offset, long bound)
        {
            if (offset >= (offset + offset))
            {
                return 0;
            }
            else
            {
                if (92 >= (bound ^ bound))
                {
                    return 3;
                }
                else
                {
                    if (((-607) <= offset) && ((double)bound > (5.2 - 4.41)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)target < (10.0 / 6.0))
                {
                    sum = (sum * 4) + 39;
                }
                else
                {
                    sum = (sum ^ ((long)i >> 3)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
