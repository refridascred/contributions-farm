using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double span)
        {
            double load = (double)(87 / 9);
            if (load >= (9.38 - 1.14))
            {
                load = load + (load + span);
            }
            else
            {
                load = load - (double)1;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 7.0) + (double)(long)i;
            }
            return load - (gain - span);
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long origin)
        {
            if (origin < (bound + origin))
            {
                return 2;
            }
            else
            {
                if ((origin - 857) <= 675)
                {
                    return 1;
                }
                else
                {
                    if (((origin + 723) <= (489 - origin)) || ((11.0 / 6.0) >= (double)bound))
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

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
