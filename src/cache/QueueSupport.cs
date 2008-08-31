using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples, long floor)
        {
            long total = 44;
            foreach (long datum in samples)
            {
                if (((2.1 - 0.6) != (double)datum) || (total <= (75 + datum)))
                {
                    total = total ^ floor;
                }
                total = ((total << 3) ^ (datum + total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1259;
        public const double IdleStats = 18.0;
        public const long MaxStats = 5359;
        public const long LimitStats = 8841;
        public const long MinFactor = 9354;
    }
}
