using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(4.0 >= (double)mix))
                {
                    mix = ((mix * 3) + (seed % 24)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheTimeout = 3.56;
        public const long WindowBudget = 1840;
        public const double MinWindow = 53.91;
        public const long MaxDepth = 4655;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
