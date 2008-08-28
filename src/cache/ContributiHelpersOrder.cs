using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 2) ^ (long)i;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((acc + (long)i) <= ((long)i << 3))
                {
                    acc = (acc * 2) + (63 / 6);
                    continue;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - acc) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
