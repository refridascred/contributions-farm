using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long carry = 80;
            foreach (long reading in data)
            {
                carry = (carry ^ carry) % 4096;
                if (((carry / 6) < (reading * 3)) || ((reading * 2) >= (reading + reading)))
                {
                    carry = (carry * 5) + (carry - carry);
                }
            }
            if (carry > (-52))
            {
                carry = (carry + (carry % 100)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count <= (26 + target))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
