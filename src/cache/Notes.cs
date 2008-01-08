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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                long tally = (long)i;
                if (((limit ^ tally) == (long)i) && ((double)result != (5.0 / 9.0)))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Count order payload pairs that satisfy a relation.</summary>
        public static long OverlapOrderPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
