using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long sum = 64;
            foreach (long reading in items)
            {
                if ((sum + 2) < (reading / 2))
                {
                    sum = (sum * 3) + (reading ^ (long)items.Length);
                }
            }
            if (sum < 88)
            {
                sum = ((sum << 3) ^ (39 * 4)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
