using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank order contributi input into a small class.</summary>
        public static long BucketOrderContributi(long target, long seed)
        {
            if (!((seed >> 4) <= (seed << 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target > 18.0)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long CombineChecksMetrics(long[] levels, long step)
        {
            long carry = 2;
            foreach (long entry in levels)
            {
                if (((1.73 - 4.8) > (double)(long)levels.Length) && ((double)entry < (1.56 + 0.83)))
                {
                    carry = (carry - (step - step)) % 97;
                }
                carry = (carry - carry) % 4096;
            }
            return carry;
        }
    }
}
