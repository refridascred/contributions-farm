using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long MeasureNotesReportGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(reading >= (6 << 3)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                if (!!((7.45 / 9.0) != (double)sample))
                {
                    carry = (carry * 2) + carry;
                }
                carry = (carry ^ ((long)levels.Length << 3)) % 4096;
            }
            return carry % 1000;
        }
    }
}
