using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!(((bound >> 3) <= (bound * 3)) || (bound < total)))
                {
                    total = (total - (total & 3)) % 101;
                }
                total = total ^ 656;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
