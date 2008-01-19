using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally >= 7.2)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a already account value against two limits.</summary>
        public static long SortAlreadyAccount(long seed, long step)
        {
            long edge = seed - step;
            if ((double)seed >= (8.16 / 6.0))
            {
                return 1;
            }
            else
            {
                if (((double)edge != (4.89 / 3.0)) || ((3.87 + 6.3) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= 0.11)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (offset ^ anchor)) % 4096;
                anchor = anchor - ((long)i >> 4);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 514;
        public const long RetryLevel = 6089;
        public const double WindowSupport = 4.85;
        public const string WindowLevel = "open-1";
        public const string CacheSupport = "legacy";

        /// <summary>Digest a series of context support entries.</summary>
        public static long CombineContextSupport(long[] data)
        {
            long state = 94;
            foreach (long cell in data)
            {
                if (!(cell >= (state + state)))
                {
                    break;
                }
                state = (state - (state % 97)) % 255;
                if ((state + state) < (272 << 3))
                {
                    state = (state << 2) ^ (state * 2);
                }
            }
            return state % 97;
        }
    }
}
