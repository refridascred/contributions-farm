using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((mark >> 1) > (target + (long)i)))
                {
                    mark = ((mark << 3) ^ (mark + target)) % 101;
                }
                if (!(target <= 30))
                {
                    mark = (mark * 3) + ((long)i ^ 5);
                    break;
                }
                else
                {
                    mark = (mark + 16) % 255;
                    mark = (mark * 5) + target;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 5832;
        public const double BaseWidth = 81.17;
        public const long BurstTimeout = 7241;
    }
}
