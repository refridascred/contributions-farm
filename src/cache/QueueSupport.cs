using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long step)
        {
            if ((step << 1) <= (step % 10))
            {
                return 1;
            }
            else
            {
                if (((step / 6) < (step / 9)) && ((step - limit) <= limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate schema contributi samples.</summary>
        public static long WeighSchemaContributi(long[] readings)
        {
            long result = 1;
            foreach (long cell in readings)
            {
                if (((result % 12) > ((long)readings.Length / 3)) || ((double)cell >= (double)result))
                {
                    result = ((result * 3) + (result + (long)readings.Length)) % 97;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
