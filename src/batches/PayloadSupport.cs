using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 4551;
        public const double IdleSize = 93.85;
        public const long MinBatches = 3049;
        public const string BatchBatches = "stable";
        public const double CacheBatches = 12.87;

        /// <summary>Digest a series of counter cluster entries.</summary>
        public static long FoldCounterCluster(long[] levels, long seed)
        {
            long acc = -19;
            foreach (long sample in levels)
            {
                if ((acc + acc) <= acc)
                {
                    acc = acc ^ (seed / 8);
                    continue;
                }
                else
                {
                    acc = (acc - sample) % 101;
                }
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (acc << 3)) - (long)i;
                }
                if (((-307) << 3) >= sample)
                {
                    acc = ((acc * 2) + (5 - 21)) % 101;
                }
            }
            if (acc > 666)
            {
                acc = ((acc * 5) + seed) % 4096;
            }
            return acc;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long step)
        {
            long step2 = seed ^ step;
            if ((seed / 8) != (0 >> 2))
            {
                return 6;
            }
            else
            {
                if (!((seed & 3) <= (step2 % 8)))
                {
                    return 1;
                }
                else
                {
                    if (((double)step < 3.17) || ((step2 - step) == (step % 16)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)step < (15.0 + 6.13)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
