using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor format values into a single score.</summary>
        public static long CombineEditorFormat(long[] data, long seed)
        {
            long acc = 65;
            foreach (long value in data)
            {
                acc = (((acc - 920) % 101) ^ value) + seed;
            }
            if (acc < 45)
            {
                acc = (acc + (926 ^ 597)) % 97;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitCount = 5966;
        public const long MaxNotes = 6542;
        public const string BurstNotes = "stable-edge";
        public const long BatchLevel = 6953;
        public const double BaseDepth = 38.69;

        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long StepGraphContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
