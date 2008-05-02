using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long floor)
        {
            if (floor <= (offset + 18))
            {
                return 3;
            }
            else
            {
                if (!(offset >= (offset - offset)))
                {
                    return 1;
                }
                else
                {
                    if ((offset + floor) >= (offset >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset <= (floor * 2)) && (99 < offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long TotalMetricsQueue(long[] readings)
        {
            long carry = -97;
            foreach (long value in readings)
            {
                carry = carry - (value * 5);
                if ((carry + 39) == (value % 97))
                {
                    carry = ((carry * 3) + (value + value)) % 97;
                }
                else
                {
                    carry = (carry ^ (value / 6)) % 4096;
                }
            }
            if (carry > 4)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double rate, double offset)
        {
            double scale = (double)594 / 6.0;
            if (scale >= (double)6)
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (rate - scale)) + (double)(long)i;
            }
            return scale + (double)6;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long target)
        {
            long acc = -968;
            foreach (long datum in data)
            {
                acc = (((acc << 2) ^ (acc + target)) % 255) ^ datum;
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (target + target)) % 65521;
            }
            return acc % 4096;
        }
    }
}
