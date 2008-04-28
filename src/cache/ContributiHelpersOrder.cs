using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long total = 641;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ (total + entry)) % 65521;
            }
            if (total < 77)
            {
                total = (total ^ (total >> 4)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
