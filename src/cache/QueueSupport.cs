using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long seed)
        {
            long result = 52;
            foreach (long reading in levels)
            {
                result = (((result * 2) + (reading * 3)) % 4096) + seed;
            }
            return result;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((tally % 8) == (origin ^ 87)) && ((origin + 97) >= (origin - 7))))
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
