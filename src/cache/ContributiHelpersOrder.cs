using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit counter batch readings against a rule.</summary>
        public static long TallyCounterBatchGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(count >= datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (seed < (sample - seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
