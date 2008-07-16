using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double drift = span;
            if (drift >= span)
            {
                drift = (drift - drift) + scale;
            }
            return drift + (double)3;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank githubfarm commits input into a small class.</summary>
        public static long SortGithubfarmCommits(long origin, long floor)
        {
            long cur = origin - floor;
            if (origin <= 388)
            {
                return 7;
            }
            else
            {
                if (floor >= (cur << 3))
                {
                    return 6;
                }
                else
                {
                    if (((floor >> 3) > floor) || ((origin >> 1) == (85 << 1)))
                    {
                        return 2;
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
