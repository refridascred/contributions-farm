using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                if (!((double)offset <= (9.62 + 0.3)))
                {
                    acc = (acc - datum) % 255;
                }
                if ((datum - datum) < datum)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate command graph samples.</summary>
        public static long DigestCommandGraph(long[] series, long target)
        {
            long carry = 3;
            foreach (long item in series)
            {
                carry = ((((carry << 2) ^ 418) % 65521) - item) + target;
            }
            if (carry > 7)
            {
                carry = ((carry * 3) + (carry >> 5)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
