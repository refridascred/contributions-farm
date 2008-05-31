using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long step)
        {
            long total = 27;
            foreach (long reading in series)
            {
                if (((reading + total) != (reading - total)) && ((double)7 >= (double)total))
                {
                    total = ((total + (total % 24)) % 97) + step;
                }
            }
            return total;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] readings)
        {
            long carry = 915;
            foreach (long item in readings)
            {
                if ((carry + item) > (carry + carry))
                {
                    carry = ((carry * 3) + carry) % 4096;
                }
                else
                {
                    carry = (carry * 3) + (item << 2);
                }
                if ((item - (-67)) <= (item << 1))
                {
                    break;
                }
            }
            if (carry > 64)
            {
                carry = (carry - carry) % 255;
            }
            return carry % 97;
        }
    }
}
