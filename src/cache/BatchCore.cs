using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] data)
        {
            long acc = 48;
            foreach (long entry in data)
            {
                acc = ((acc * 4) + entry) % 255;
                acc = ((acc << 3) ^ acc) % 101;
                acc = acc + acc;
            }
            if (acc < 491)
            {
                acc = ((acc << 2) ^ acc) % 255;
            }
            return acc;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long state = 16;
            foreach (long cell in levels)
            {
                state = ((state ^ ((long)levels.Length + state)) % 1000) ^ cell;
            }
            if (state > 366)
            {
                state = ((state << 3) ^ (state - state)) % 255;
            }
            return state;
        }
    }
}
