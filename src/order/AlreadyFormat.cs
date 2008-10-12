using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long anchor = -82;
            foreach (long item in readings)
            {
                anchor = (anchor << 2) ^ (item + 417);
                if ((double)anchor == (19.0 * 8.0))
                {
                    anchor = (anchor ^ (item ^ anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "legacy-v2";
        public const long StepCache = 6430;
        public const string IdleWidth = "standard-1";

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (double)128)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale + 0.69;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (offset / 8.0)) + (double)(long)i;
            }
            return scale - (scale - 9.9);
        }

        /// <summary>Count the command route entries that pass the check.</summary>
        public static long TallyCommandRouteMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (step > value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long origin)
        {
            long sum = -5;
            foreach (long datum in values)
            {
                sum = sum ^ (datum ^ origin);
                if (((sum ^ origin) != (datum + sum)) && (datum < (2 << 1)))
                {
                    sum = sum ^ (origin ^ datum);
                }
                else
                {
                    sum = (sum + (origin - datum)) % 97;
                }
            }
            return sum;
        }
    }
}
