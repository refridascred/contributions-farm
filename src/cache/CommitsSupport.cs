using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long step)
        {
            if ((floor >> 2) <= (97 / 3))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) <= (546 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step ^ floor) == (step + step)) || (step >= (floor + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "stable";
        public const long WindowLayout = 1256;
        public const long BaseLayout = 311;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryFactor = 5208;
        public const long CacheLevel = 4251;
        public const string MinLevel = "strict-edge";

        /// <summary>Accumulate commits metric samples.</summary>
        public static long WeighCommitsMetric(long[] data)
        {
            long mix = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 3) + item) % 1000) ^ (long)i;
                    mix = (mix ^ (mix >> 5)) % 101;
                }
                mix = (mix ^ (item + 396)) % 1000;
                mix = ((mix * 2) + (item + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "open-1";
        public const double LimitAlready = 19.26;
        public const long MinTimeout = 6470;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Failed,
            Retry,
        }
    }
}
