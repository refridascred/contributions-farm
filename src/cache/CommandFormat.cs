using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry << 3) ^ (2 - (long)i2);
                    carry = (carry ^ (-6)) % 255;
                }
                carry = ((carry * 2) + ((long)i - seed)) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
