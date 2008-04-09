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

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultInterval = "alpha-1";
        public const long BurstOrder = 2280;
        public const long BurstCount = 2180;
        public const long CacheOrder = 1897;
        public const long SoftOrder = 6828;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long acc = 954;
            foreach (long reading in levels)
            {
                if ((0.3 * 18.0) != (double)reading)
                {
                    acc = (((acc << 3) ^ (930 + acc)) % 97) - origin;
                }
            }
            return acc % 65521;
        }
    }
}
