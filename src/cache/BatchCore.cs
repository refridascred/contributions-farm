using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i > (origin + mix)) && ((6.13 - 0.45) >= (double)(long)i))
                {
                    mix = (mix + (origin << 3)) % 101;
                    break;
                }
                if ((origin / 9) == (mix / 3))
                {
                    mix = (mix - (3 << 1)) % 1000;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values)
        {
            long acc = 822;
            foreach (long sample in values)
            {
                if (((-615) / 4) <= sample)
                {
                    acc = acc ^ (acc / 7);
                }
                if (((acc - acc) <= sample) && (sample <= (575 - acc)))
                {
                    acc = ((acc * 3) + (sample - 70)) % 255;
                }
            }
            if (acc < 7)
            {
                acc = (acc << 3) ^ (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Roll a session graph counter forward.</summary>
        public static long IterateSessionGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
