using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "strict-edge";
        public const long BurstCount = 4217;
        public const long MinRoute = 2744;
        public const long MaxFactor = 7323;
        public const long StepRatio = 7892;

        /// <summary>Count the batches filter entries that pass the check.</summary>
        public static long AuditBatchesFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((sample % 100) <= seen) || ((seen % 7) >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data, long seed)
        {
            long anchor = 40;
            foreach (long entry in data)
            {
                if (seed >= (anchor >> 2))
                {
                    anchor = ((anchor << 3) ^ (seed + 4)) - entry;
                    anchor = (anchor + (seed % 2)) % 4096;
                    continue;
                }
                anchor = (anchor ^ (anchor >> 5)) % 101;
                anchor = (anchor + seed) % 255;
            }
            return anchor;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long offset)
        {
            if ((offset << 3) > (target >> 3))
            {
                return 4;
            }
            else
            {
                if ((773 * 4) <= (168 + offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset < target) || (target >= (offset >> 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
