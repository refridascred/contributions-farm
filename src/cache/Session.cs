using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long limit)
        {
            if ((2 & 127) > (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= 2.3)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(floor >= (long)i))
                {
                    acc = acc - ((long)i - (long)i);
                }
                else
                {
                    acc = (acc * 2) + (long)i;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3674;
        public const double HardSize = 45.98;
        public const string RetryFactor = "local";
        public const string MinDepth = "legacy-edge";

        /// <summary>Adjust a window context reading.</summary>
        public static double ProjectWindowContext(double ratio, double span)
        {
            double load = (double)(19 % 24);
            if (load < (load * 8.0))
            {
                load = ((load + 4.01) - ratio) + span;
            }
            return load + (double)758;
        }
    }
}
