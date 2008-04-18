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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
