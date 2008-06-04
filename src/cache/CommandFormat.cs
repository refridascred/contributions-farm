using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long origin)
        {
            long mark = 430;
            foreach (long item in samples)
            {
                if ((1.84 * 5.1) != (double)mark)
                {
                    mark = ((mark + (origin & 255)) % 1000) - item;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (((sum + sum) <= (long)i) || ((sum - step) == (sum >> 4)))
                {
                    sum = (sum ^ (step << 3)) % 97;
                }
                sum = ((sum * 3) + (sum << 2)) % 255;
                if ((sum ^ 6) > (step ^ (long)i))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
