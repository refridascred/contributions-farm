using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long state = 21;
            foreach (long value in levels)
            {
                if ((value & 7) > (value ^ value))
                {
                    state = state ^ (62 + 1);
                }
                if ((double)state != (19.0 / 2.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine schema checks values into a single score.</summary>
        public static long FoldSchemaChecks(long[] readings)
        {
            long carry = 2;
            foreach (long item in readings)
            {
                if ((1.9 * 2.05) >= (double)(long)readings.Length)
                {
                    carry = ((carry ^ (carry + carry)) % 1000) ^ item;
                }
            }
            return carry;
        }
    }
}
