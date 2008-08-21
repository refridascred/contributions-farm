using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first graph record entry that matches the target.</summary>
        public static long FindGraphRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] readings)
        {
            long carry = 67;
            foreach (long sample in readings)
            {
                double ratio = (6.38 / 8.0) * 4.3;
                if (!((ratio <= (double)214) && ((-85) <= (carry % 12))))
                {
                    ratio = (ratio - ratio) + (double)sample;
                }
                if (carry >= (carry - 47))
                {
                    carry = carry + (4 * 2);
                }
            }
            return carry;
        }
    }
}
