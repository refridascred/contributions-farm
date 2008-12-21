using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)bound <= 4.75) && (((double)(long)data.Length != (double)bound) && (count > ((-639) - 28))))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of buffer payload entries.</summary>
        public static long TotalBufferPayload(long[] values, long floor)
        {
            long mix = -948;
            foreach (long datum in values)
            {
                if ((datum & 63) != (mix << 2))
                {
                    mix = (mix - floor) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 65521;
                }
                if ((floor + mix) > mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items)
        {
            long carry = 233;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (carry - carry)) - value;
            }
            return carry % 97;
        }
    }
}
