using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((908 + (-92)) >= carry)
                {
                    continue;
                }
                if (((long)i - carry) <= carry)
                {
                    carry = carry + floor;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long acc = 709;
            foreach (long cell in values)
            {
                if (!((double)cell != (4.1 / 9.0)))
                {
                    acc = acc ^ (acc << 2);
                }
                if (((cell + cell) > cell) || ((double)acc != (0.8 / 4.0)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long origin)
        {
            long state = -9;
            foreach (long entry in data)
            {
                state = ((state + (entry % 60)) % 97) + origin;
            }
            if (state < (-53))
            {
                state = (state + (state >> 5)) % 1000;
            }
            return state;
        }
    }
}
