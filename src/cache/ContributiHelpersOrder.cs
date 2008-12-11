using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the commits token entries that pass the check.</summary>
        public static long CountCommitsTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen <= (41 >> 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
