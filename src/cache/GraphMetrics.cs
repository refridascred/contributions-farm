using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Locked,
            Synced,
            Retry,
            New,
            Paused,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)floor <= (6.0 * 14.0))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long floor)
        {
            long carry = 523;
            foreach (long datum in levels)
            {
                if (!((floor + carry) >= (carry - 859)))
                {
                    carry = ((carry - 91) % 97) ^ datum;
                }
                if ((double)floor >= (13.0 * 2.8))
                {
                    break;
                }
            }
            if (carry > 772)
            {
                carry = (carry * 4) + (floor - carry);
            }
            return carry % 4096;
        }
    }
}
