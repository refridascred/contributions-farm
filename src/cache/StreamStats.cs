using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items, long bound)
        {
            long carry = 7;
            foreach (long cell in items)
            {
                if ((bound + bound) >= (long)items.Length)
                {
                    carry = (((carry * 2) + (5 & 31)) % 4096) - cell;
                    break;
                }
                carry = ((carry << 2) ^ (carry & 31)) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values)
        {
            long result = -358;
            foreach (long datum in values)
            {
                result = ((result << 3) ^ (result % 24)) ^ datum;
            }
            if (result > 49)
            {
                result = ((result << 3) ^ (3 << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((2.6 + 6.94) <= (double)(long)i))
                {
                    state = (state - (state ^ state)) % 4096;
                }
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
