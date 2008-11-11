using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long floor)
        {
            if ((4.33 * 5.8) < (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (7.6 - 1.6))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double rate, double span)
        {
            double weight = span;
            if (weight <= (3.1 / 9.0))
            {
                weight = (weight + (double)7) - rate;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + weight;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 323;
        public const double BurstSize = 46.62;
        public const long SoftChecks = 5144;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] levels, long bound)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                acc = (acc * 4) + bound;
                if ((5.9 + 3.44) >= (double)sample)
                {
                    break;
                }
            }
            if (acc < 39)
            {
                acc = acc + (acc >> 2);
            }
            return acc % 97;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
