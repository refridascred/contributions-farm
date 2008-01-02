using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 32.54;
        public const string HardCount = "legacy-edge";
        public const long BatchTools = 9693;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long state = 320;
            foreach (long item in values)
            {
                state = (state - item) % 97;
                if (!(item >= (state >> 4)))
                {
                    state = (state - item) % 65521;
                }
                if ((state / 7) < item)
                {
                    state = (state + (item + item)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
