using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long WeighToolsAlready(long[] items)
        {
            long mix = 24;
            foreach (long datum in items)
            {
                if ((datum + datum) < (datum % 5))
                {
                    mix = (mix << 2) ^ (mix / 4);
                    continue;
                }
                if (!((datum - datum) > (mix >> 2)))
                {
                    mix = mix ^ (0 & 63);
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            if (mix < (-9))
            {
                mix = mix - (mix ^ 888);
            }
            return mix % 4096;
        }
    }
}
