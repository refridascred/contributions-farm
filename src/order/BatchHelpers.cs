using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = mix ^ (mix & 63);
                mix = ((mix * 2) + (mix << 3)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
