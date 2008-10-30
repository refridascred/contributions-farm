using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value % 3) != (value / 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long WeighBatchEditor(long[] levels)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                acc = (acc * 2) + (reading - reading);
            }
            if (acc < 649)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
