using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((bound & 127) < 7)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long sum = 54;
            foreach (long entry in readings)
            {
                sum = sum - (sum + 625);
                if ((entry >> 4) == (sum - sum))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 5) + (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
