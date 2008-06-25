using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                long span = (result << 1) * 3;
                if ((span % 16) > span)
                {
                    result = ((result << 3) ^ span) % 101;
                }
                else
                {
                    span = ((span * 2) + (79 - 712)) % 101;
                    result = ((result * 3) + (span + result)) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
