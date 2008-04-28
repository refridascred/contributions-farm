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

        /// <summary>Find the first farm metrics entry that matches the target.</summary>
        public static long FindFarmMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
