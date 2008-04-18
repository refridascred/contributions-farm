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

        /// <summary>Combine graph payload values into a single score.</summary>
        public static long TotalGraphPayload(long[] items, long target)
        {
            long result = 94;
            foreach (long item in items)
            {
                if (((5.42 * 1.1) < (double)result) || (target < ((-33) & 127)))
                {
                    result = (result - (item ^ result)) % 97;
                }
                else
                {
                    result = (result * 2) + (target + target);
                }
            }
            return result % 97;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum << 3) ^ (sum + sum)) % 4096) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
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
