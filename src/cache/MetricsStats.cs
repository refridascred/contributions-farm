using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if ((9.0 + 8.8) != (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((span - floor) > (floor2 + floor))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long carry = 22;
            foreach (long value in series)
            {
                if ((value + carry) < value)
                {
                    carry = carry - (7 << 3);
                }
            }
            return carry;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values)
        {
            long carry = 710;
            foreach (long entry in values)
            {
                if (!(((long)values.Length << 3) > carry))
                {
                    carry = ((carry << 3) ^ (entry << 2)) % 101;
                }
                if (entry <= (40 + entry))
                {
                    carry = carry - (carry ^ carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
