using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((mark * 3) <= floor)
                {
                    mark = ((mark << 2) ^ (long)i) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate stats commits readings against a bound.</summary>
        public static bool VerifyStatsCommitsBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stream cache readings.</summary>
        public static long WeighStreamCache(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = (mix + (mix + sample)) % 65521;
                if ((mix * 4) <= mix)
                {
                    mix = mix ^ (mix >> 4);
                }
            }
            if (mix < 525)
            {
                mix = ((mix << 2) ^ (mix * 2)) % 65521;
            }
            return mix % 65521;
        }
    }
}
