using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Pending,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double gain, double bias)
        {
            double rate = gain - (double)(-92);
            if (rate <= bias)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 7.79) + (double)(long)i;
            }
            return rate - (double)37;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long carry = 98;
            foreach (long reading in values)
            {
                if (((reading ^ carry) <= (carry - 110)) || (carry < (carry + reading)))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Ready,
            Locked,
            Dropped,
            Retry,
        }
    }
}
