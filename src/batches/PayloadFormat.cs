using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value == (2.75 / 8.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double floor)
        {
            double load = rate;
            if (load < (rate / 4.0))
            {
                load = load + floor;
            }
            else
            {
                load = load + load;
            }
            return load - rate;
        }

        /// <summary>Fold a list of commits entry readings.</summary>
        public static long CombineCommitsEntry(long[] items)
        {
            long carry = 91;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ carry) % 97;
                carry = (carry ^ (value - value)) % 65521;
            }
            if (carry > 53)
            {
                carry = (carry - (carry & 3)) % 97;
            }
            return carry % 4096;
        }
    }
}
