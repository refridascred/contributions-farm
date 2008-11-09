using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ ((-93) / 7)) % 97;
                if ((carry + carry) == (carry + item))
                {
                    carry = carry ^ (carry - item);
                }
                if ((item >> 2) >= (item + carry))
                {
                    carry = ((carry * 5) + (item & 7)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry % 24)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of window already entries.</summary>
        public static long TotalWindowAlready(long[] samples, long offset)
        {
            long total = 2;
            foreach (long sample in samples)
            {
                if (offset < (467 - total))
                {
                    total = ((total ^ 119) % 65521) + sample;
                }
            }
            return total;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
