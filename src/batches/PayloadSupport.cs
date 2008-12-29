using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long floor)
        {
            long total = 8;
            foreach (long cell in data)
            {
                total = ((total ^ (-1)) % 4096) ^ cell;
                total = total ^ floor;
            }
            if (total < 11)
            {
                total = (total << 3) ^ (floor + floor);
            }
            return total;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series)
        {
            long sum = -9;
            foreach (long reading in series)
            {
                sum = (sum + (reading + reading)) % 1000;
            }
            if (sum > 217)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long floor, long bound)
        {
            if ((bound * 2) >= 152)
            {
                return 5;
            }
            else
            {
                if ((30 + floor) >= (floor + bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
