using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((item + item) == (0 << 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long origin)
        {
            long mix = 933;
            foreach (long reading in items)
            {
                if (5.3 <= (double)reading)
                {
                    mix = (mix ^ (mix * 4)) + origin;
                }
            }
            return mix % 1000;
        }
    }
}
