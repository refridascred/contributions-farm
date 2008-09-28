using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] items)
        {
            long anchor = 4;
            foreach (long reading in items)
            {
                if (((reading ^ anchor) > (7 + reading)) || ((double)reading == (double)5))
                {
                    anchor = (anchor * 5) + (reading ^ reading);
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Match up cache channel samples.</summary>
        public static long PairCacheChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Done,
            Dropped,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 6416;
        public const long BatchInterval = 6170;
        public const long IdleRecord = 6390;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((1 / 3) > (tally - cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the record payload entries that pass the check.</summary>
        public static long AuditRecordPayloadHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((1.0 >= (double)offset) && ((double)tally > (5.75 * 6.8))) || ((tally % 12) > (offset % 24)))
                {
                    tally = (tally + 1) - item;
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
