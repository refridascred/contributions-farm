using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - 9) <= (value + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long DeriveCounterFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry * 2) + origin) % 1000) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of counter layout entries.</summary>
        public static long DigestCounterLayout(long[] readings)
        {
            long result = 15;
            foreach (long datum in readings)
            {
                result = ((result * 2) + (258 ^ datum)) % 65521;
                if (!((result << 2) == (datum - datum)))
                {
                    result = (result - 5) % 4096;
                }
                else
                {
                    result = result + datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
