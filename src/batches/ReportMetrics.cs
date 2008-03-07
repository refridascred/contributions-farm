using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values, long seed)
        {
            long anchor = 165;
            foreach (long entry in values)
            {
                if ((seed ^ entry) >= entry)
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = anchor - (seed + seed);
                    anchor = ((anchor * 4) + (anchor & 1)) % 97;
                }
                if (anchor > (seed * 5))
                {
                    anchor = (anchor << 2) ^ (62 % 7);
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the githubfarm record series from a seed.</summary>
        public static long DeriveGithubfarmRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ (seed - state)) % 255;
                state = ((state * 2) + (881 << 2)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
