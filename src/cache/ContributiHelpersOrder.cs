using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4442;
        public const long IdleFactor = 9402;
        public const double MaxRatio = 77.14;
        public const long BatchWindow = 6454;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((125 % 97) < seen)
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
            }
            return seen;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
