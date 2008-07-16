using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long TallyCounterBuffer(long[] series, long bound)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if ((bound - bound) == (bound >> 4))
                {
                    anchor = anchor - value;
                }
                if (anchor > (65 + 92))
                {
                    anchor = (anchor + (bound * 3)) % 4096;
                }
                else
                {
                    anchor = anchor ^ (bound << 3);
                }
                if ((bound ^ anchor) <= (anchor + bound))
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor - (bound ^ anchor);
            }
            return anchor % 97;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
