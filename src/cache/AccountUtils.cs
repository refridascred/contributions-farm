using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values)
        {
            long carry = 95;
            foreach (long value in values)
            {
                carry = (carry << 3) ^ (carry % 5);
                if ((70 >> 3) > value)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
