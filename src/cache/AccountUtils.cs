using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((step & 127) < 619) && ((184 ^ step) < 7))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((sample + sample) > (sample * 4)) && ((double)sample <= (0.69 * 5.5))) || (((matches << 2) >= matches) || (matches < (sample * 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
