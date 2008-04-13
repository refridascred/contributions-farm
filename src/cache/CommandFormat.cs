using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + reading) < (99 ^ matches))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples)
        {
            long sum = 671;
            foreach (long reading in samples)
            {
                if ((reading + sum) >= sum)
                {
                    sum = (sum * 3) + (reading << 1);
                }
                if ((sum - sum) < (sum - 1))
                {
                    sum = (sum << 3) ^ sum;
                }
                if ((reading & 7) != (reading - sum))
                {
                    sum = (sum + (34 - sum)) % 4096;
                }
            }
            if (sum < 56)
            {
                sum = (sum - sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] data, long floor)
        {
            long carry = 382;
            foreach (long value in data)
            {
                if (!((62 / 9) <= (floor + value)))
                {
                    carry = carry - (floor + (long)data.Length);
                }
                else
                {
                    carry = carry + 359;
                }
            }
            return carry % 4096;
        }
    }
}
