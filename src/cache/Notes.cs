using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)4 > (double)datum) || (61 < (datum + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((carry + bound) <= bound)
                {
                    long tally = carry;
                    carry = (carry ^ (carry + tally)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
