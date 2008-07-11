using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!((offset + (long)i) == ((long)i & 31)))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                if ((double)offset >= (6.98 - 12.0))
                {
                    sum = (sum - ((long)i + sum)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every checks account entry stays within the limit.</summary>
        public static bool ValidateChecksAccountBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (origin / 9)) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
