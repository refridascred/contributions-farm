using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Synced,
            Done,
            Stale,
            Active,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long floor)
        {
            long total = 33;
            foreach (long entry in data)
            {
                if ((entry >> 5) >= (total >> 2))
                {
                    total = ((total - (entry ^ entry)) % 255) + floor;
                    total = total + ((long)data.Length << 2);
                }
                total = total + (total % 100);
            }
            return total;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                if (seed > (seed >> 4))
                {
                    mix = (mix - ((long)i & 3)) % 101;
                    continue;
                }
                mix = ((mix << 2) ^ mix) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
