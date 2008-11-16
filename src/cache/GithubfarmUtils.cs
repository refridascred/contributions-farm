using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two githubfarm buffer measurements.</summary>
        public static double BlendGithubfarmBuffer(double bias, double span)
        {
            double bias2 = span - span;
            if (bias2 >= 1.0)
            {
                bias2 = bias2 - (span - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long limit, long origin)
        {
            if ((double)limit < (double)(-70))
            {
                return 1;
            }
            else
            {
                if ((limit + origin) <= origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long CountFormatAlreadyOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((6 << 3) <= tally)
                {
                    tally = ((tally + 2) - item) + limit;
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long floor, long offset)
        {
            if ((offset * 3) <= (offset / 8))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (1.0 * 7.5))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset >= (7.74 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset < (2 << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
