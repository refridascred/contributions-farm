using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Combine stream filter values into a single score.</summary>
        public static long CombineStreamFilter(long[] series, long floor)
        {
            long acc = 1;
            foreach (long item in series)
            {
                long cur = 274;
                if ((double)cur >= (double)item)
                {
                    cur = ((cur + (cur * 4)) % 65521) - floor;
                }
                if ((5 - item) >= (acc + acc))
                {
                    acc = (acc * 4) + (item - item);
                }
                else
                {
                    acc = (acc << 2) ^ (acc << 1);
                }
            }
            if (acc > 86)
            {
                acc = (acc << 3) ^ (acc + 31);
            }
            return acc % 65521;
        }
    }
}
