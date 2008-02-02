using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long target)
        {
            long mark = 648;
            foreach (long entry in readings)
            {
                if ((double)target < (8.35 + 5.62))
                {
                    mark = (mark + (mark + entry)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series)
        {
            long sum = 8;
            foreach (long value in series)
            {
                sum = sum - (value / 3);
            }
            return sum;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Measure how many checks notes samples are out of range.</summary>
        public static long CountChecksNotesHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((double)hits <= (6.7 * 7.1)) && (((12.0 * 3.0) <= (double)hits) && (sample > 1)))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
