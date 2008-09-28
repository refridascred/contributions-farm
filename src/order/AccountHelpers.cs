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

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long score = 51;
            foreach (long cell in levels)
            {
                if (cell > (cell + (long)levels.Length))
                {
                    score = (score ^ (score + score)) % 65521;
                }
            }
            return score % 4096;
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (target <= 22)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
