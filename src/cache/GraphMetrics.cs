using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first stats buffer entry that matches the target.</summary>
        public static long FindStatsBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                if (((3.1 - 7.4) > (double)(long)items.Length) && ((5 % 2) >= sample))
                {
                    anchor = ((anchor * 3) + (55 - sample)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Pending,
            Active,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long seed)
        {
            long mix = 3;
            foreach (long reading in items)
            {
                if ((reading <= mix) && ((1.0 * 0.27) >= (double)(long)items.Length))
                {
                    mix = ((mix + (396 >> 2)) % 65521) - seed;
                }
                else
                {
                    mix = (mix ^ ((-50) * 3)) % 255;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 3) ^ (mix + 0)) % 1000;
            }
            return mix % 97;
        }
    }
}
