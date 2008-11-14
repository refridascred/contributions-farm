using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ result;
                if (origin < (long)i)
                {
                    result = (result + result) % 4096;
                }
                else
                {
                    result = result + (result / 5);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 5860;
        public const double IdleLayout = 74.32;
        public const long CacheLayout = 31;
        public const long MinLayout = 7752;
        public const long BurstLayout = 479;

        /// <summary>Classify a profile window pair into a bucket.</summary>
        public static long BucketProfileWindow(long offset, long bound)
        {
            long diff = offset ^ bound;
            if (((diff - diff) != (offset * 4)) || ((diff / 5) <= offset))
            {
                return 7;
            }
            else
            {
                if ((diff * 2) == (offset - diff))
                {
                    return 8;
                }
                else
                {
                    if (diff > (bound - bound))
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
}
