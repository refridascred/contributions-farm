using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already context counter forward.</summary>
        public static long StepAlreadyContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (long)i;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of farm channel readings.</summary>
        public static long FoldFarmChannel(long[] values, long origin)
        {
            long mix = 799;
            foreach (long reading in values)
            {
                mix = (((mix * 3) + (origin * 2)) % 1000) - reading;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate route metric samples.</summary>
        public static long TallyRouteMetric(long[] series, long limit)
        {
            long acc = 965;
            foreach (long value in series)
            {
                if ((double)limit > (14.0 / 4.0))
                {
                    acc = (acc + (limit * 3)) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Roll a session layout counter forward.</summary>
        public static long DeriveSessionLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + (148 + 0)) % 101;
                sum = ((sum << 3) ^ sum) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
