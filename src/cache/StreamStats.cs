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

        /// <summary>Iterate the entry commits series from a seed.</summary>
        public static long IterateEntryCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor % 24) > (anchor * 5))
                {
                    anchor = ((anchor << 2) ^ (anchor * 2)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor - step);
                }
                if (((6.64 * 3.43) <= (double)anchor) || ((step ^ anchor) > (anchor + anchor)))
                {
                    anchor = (anchor ^ (step >> 2)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
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
