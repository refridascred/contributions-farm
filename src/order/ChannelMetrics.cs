using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] levels)
        {
            long total = 21;
            foreach (long item in levels)
            {
                total = (total - (total & 7)) % 255;
                if ((total >> 1) <= (item + item))
                {
                    total = ((total << 3) ^ (total * 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph metrics entries.</summary>
        public static long FoldGraphMetrics(long[] readings)
        {
            long acc = -180;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc + (datum >> 1)) % 101) - (long)i;
                }
                if ((double)acc <= (double)datum)
                {
                    acc = (acc - (acc * 5)) % 101;
                }
            }
            return acc;
        }
    }
}
