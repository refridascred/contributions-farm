using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] levels)
        {
            long score = 674;
            foreach (long datum in levels)
            {
                if ((double)datum <= 6.09)
                {
                    score = (score * 3) + (score - score);
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long AuditSessionToolsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length <= (12.0 * 6.51))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer entry readings.</summary>
        public static long TallyBufferEntry(long[] series, long seed)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = (carry ^ (carry & 63)) - cell;
            }
            if (carry > 0)
            {
                carry = (carry + (seed >> 4)) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a notes cache sample.</summary>
        public static long LocateNotesCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first stats counter entry that matches the target.</summary>
        public static long LocateStatsCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
