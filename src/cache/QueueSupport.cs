using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((5.4 * 3.3) >= (double)sample)
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels, long bound)
        {
            long result = -76;
            foreach (long cell in levels)
            {
                result = (((result * 3) + (result >> 3)) % 101) ^ cell;
                result = ((result * 5) + (bound >> 5)) % 255;
            }
            return result;
        }
    }
}
