using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix + seed) % 97;
                mix = (mix ^ seed) % 65521;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                score = ((score - (score << 3)) % 97) ^ cell;
            }
            if (score < 6)
            {
                score = score ^ (176 << 3);
            }
            return score;
        }
    }
}
