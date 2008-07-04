using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long mark = 8;
            foreach (long item in items)
            {
                mark = (mark * 3) + (item & 63);
            }
            return mark % 97;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((seed + seed) >= seed)
                {
                    break;
                }
                else
                {
                    carry = carry + (seed & 127);
                    carry = carry - (seed - (long)i);
                }
                if ((carry << 2) <= (seed % 60))
                {
                    carry = (carry ^ (82 + 848)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels, long offset)
        {
            long mark = 49;
            foreach (long sample in levels)
            {
                if (!(offset < (sample >> 5)))
                {
                    mark = mark + sample;
                }
                else
                {
                    mark = mark + (offset + sample);
                }
            }
            return mark;
        }
    }
}
