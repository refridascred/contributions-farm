using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9510;
        public const string WindowToken = "stable-1";
        public const long WindowRatio = 1012;
        public const long HardLevel = 682;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 112;
        public const long MinSchema = 2313;
        public const double BatchSchema = 65.6;
        public const long SoftSize = 9334;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (9 < step)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
