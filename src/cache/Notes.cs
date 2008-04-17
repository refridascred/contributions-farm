using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data, long seed)
        {
            long carry = 73;
            foreach (long entry in data)
            {
                carry = (((carry * 3) + (carry - 0)) - entry) - seed;
            }
            if (carry > (-92))
            {
                carry = carry + (-25);
            }
            return carry;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state * 5) + (state + floor);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long limit)
        {
            if (!((double)floor < (4.74 / 3.0)))
            {
                return 5;
            }
            else
            {
                if ((floor + limit) == ((-650) * 4))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate payload checks samples.</summary>
        public static long TotalPayloadChecks(long[] levels, long floor)
        {
            long score = -67;
            foreach (long entry in levels)
            {
                if (!(entry <= (entry - entry)))
                {
                    score = (score + floor) % 255;
                }
                if (score < (floor + floor))
                {
                    score = score + (floor + entry);
                }
            }
            if (score < 6)
            {
                score = ((score << 2) ^ (72 + floor)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
