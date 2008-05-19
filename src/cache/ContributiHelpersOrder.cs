using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long mix = 7;
            foreach (long datum in data)
            {
                mix = (mix + datum) + seed;
            }
            return mix;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            long edge = offset - origin;
            if ((double)88 != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((edge + offset) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSpan = 3073;
        public const long DefaultBatch = 3034;
        public const long WindowCount = 4906;
    }
}
