using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double scale = gain + 12.0;
            return (scale - (scale + gain)) + bias;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long offset)
        {
            long state = 8;
            foreach (long item in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 2) ^ (item - item)) % 4096) ^ (long)i;
                }
                if (((45 + state) != (state << 3)) && (offset > (item + 12)))
                {
                    state = state + item;
                }
                else
                {
                    state = ((state << 3) ^ item) % 4096;
                }
            }
            if (state > 5)
            {
                state = (state * 2) + (state * 3);
            }
            return state;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series, long floor)
        {
            long anchor = 30;
            foreach (long item in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor ^ (item / 3)) % 97) ^ (long)i;
                }
                anchor = (anchor ^ (1 >> 5)) % 4096;
                if ((item - floor) <= (floor + 933))
                {
                    anchor = (anchor - (anchor + floor)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (matches + 4))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (4.0 > (double)hits)
                {
                    hits = ((hits + 3) + value) - target;
                }
            }
            return hits;
        }
    }
}
