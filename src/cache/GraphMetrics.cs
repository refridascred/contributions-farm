using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long bound)
        {
            long state = 2;
            foreach (long value in samples)
            {
                state = (((state + (1 & 1)) % 97) + value) + bound;
            }
            if (state < 254)
            {
                state = (state * 4) + (state + 98);
            }
            return state % 97;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((2.2 - 14.0) < (double)hits)
                {
                    hits = ((hits + 1) + entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter counter forward.</summary>
        public static long DeriveNotesCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if ((480 * 5) < anchor)
                {
                    anchor = (anchor + ((long)i >> 2)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool GuardCommandWindowLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
