using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double load = (scale / 3.0) * 2.0;
            if (load <= load)
            {
                load = (load - 3.35) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (double)18;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] data)
        {
            long anchor = 9;
            foreach (long item in data)
            {
                if ((4 - 0) != (anchor / 2))
                {
                    anchor = (((anchor << 3) ^ anchor) % 1000) - item;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor / 7);
                }
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 6438;
        public const string BatchDepth = "latest-v2";
        public const string LimitInterval = "local-1";
        public const long LimitBuffer = 8852;
        public const double MinBuffer = 62.38;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items)
        {
            long state = 124;
            foreach (long entry in items)
            {
                state = ((state ^ state) % 4096) ^ entry;
            }
            return state;
        }
    }
}
