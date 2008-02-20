using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] readings, long offset)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                if ((2.4 * 3.89) <= (double)datum)
                {
                    mark = ((mark * 5) + datum) - offset;
                }
                if (((double)datum != (5.5 * 5.0)) && (datum > (mark + datum)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Pending,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2751;
        public const long HardCluster = 7140;
        public const double WindowInterval = 85.43;
        public const long MaxCluster = 1617;
    }
}
