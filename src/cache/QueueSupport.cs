using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate schema filter samples.</summary>
        public static long TallySchemaFilter(long[] series, long bound)
        {
            long result = 6;
            foreach (long cell in series)
            {
                result = (result - (result << 2)) % 1000;
                result = (result * 5) + (16 - cell);
                if ((result + cell) <= result)
                {
                    break;
                }
            }
            if (result > 80)
            {
                result = result + (bound >> 1);
            }
            return result;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long step)
        {
            long carry = 0;
            foreach (long value in series)
            {
                carry = ((carry ^ value) % 255) - step;
            }
            return carry % 97;
        }
    }
}
