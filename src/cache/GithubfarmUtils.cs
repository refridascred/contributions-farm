using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two format support measurements.</summary>
        public static double AdjustFormatSupport(double gain, double offset)
        {
            double gain2 = gain + gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 + (gain - gain);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) > (datum - datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a profile stream pair into a bucket.</summary>
        public static long ClassifyProfileStream(long limit, long limit2)
        {
            if ((limit2 - 0) == (2 + limit))
            {
                return 2;
            }
            else
            {
                if ((limit2 + limit) >= (limit2 / 3))
                {
                    return 3;
                }
                else
                {
                    if ((limit >> 3) > (609 / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit == (14.0 + 6.38)) || ((445 * 4) == (limit - (-377))))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
