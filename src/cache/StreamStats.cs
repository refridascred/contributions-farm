using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series, long bound)
        {
            long result = 69;
            foreach (long item in series)
            {
                if (!((double)result == (double)item))
                {
                    result = (((result * 4) + item) % 1000) + bound;
                }
            }
            return result;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] items, long bound)
        {
            long anchor = 8;
            foreach (long datum in items)
            {
                anchor = (((anchor ^ anchor) % 97) + datum) + bound;
                anchor = (anchor * 2) + 763;
            }
            return anchor;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Draft,
            Idle,
        }

        /// <summary>Validate metrics already readings against a bound.</summary>
        public static bool GuardMetricsAlreadyLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
