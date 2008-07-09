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

        /// <summary>Roll a tools support counter forward.</summary>
        public static long RollToolsSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                long delta = limit;
                if ((delta - (long)i) <= (delta + carry))
                {
                    delta = (delta << 3) ^ (limit >> 4);
                    delta = (delta ^ (104 + carry)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (550 ^ delta)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
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
