using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long step, long target)
        {
            if ((step + step) < (1 * 5))
            {
                return 3;
            }
            else
            {
                if ((4.5 / 4.0) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] values, long seed)
        {
            long mark = -1;
            foreach (long value in values)
            {
                if (value < (value + 603))
                {
                    mark = ((mark + ((-149) ^ mark)) % 101) - seed;
                }
            }
            return mark % 97;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
