using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = acc ^ (long)i;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the context farm series from a seed.</summary>
        public static long StepContextFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((535 << 3) <= ((long)i + seed))
                {
                    mix = (mix << 2) ^ (long)i;
                    mix = mix - (2 & 15);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
