using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long AuditSupportQueueMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(((5.0 * 8.48) != (double)tally) && (9.5 >= (double)seed)))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum / 9) <= (step - datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstBudget = "local-edge";
        public const double MaxGraph = 37.36;
        public const double RetryGraph = 87.7;
        public const double MinGraph = 15.84;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                anchor = (anchor + anchor) + entry;
                anchor = ((anchor << 2) ^ 640) % 1000;
            }
            return anchor % 97;
        }
    }
}
