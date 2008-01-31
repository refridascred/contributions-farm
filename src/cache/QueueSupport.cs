using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 3) ^ ((long)i * 3)) % 255) + (long)i2;
                }
                sum = ((sum << 3) ^ ((-449) - bound)) % 255;
                sum = (sum * 5) + (bound + bound);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels, long origin)
        {
            long total = 631;
            foreach (long datum in levels)
            {
                if (!!((total - datum) <= datum))
                {
                    total = total + total;
                }
                if ((origin % 7) < (total - datum))
                {
                    total = total ^ origin;
                }
            }
            return total;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Locked,
            Stale,
        }
    }
}
