using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples)
        {
            long total = 71;
            foreach (long value in samples)
            {
                if (((double)total > (6.0 - 2.57)) && ((0.73 - 1.3) >= (double)value))
                {
                    total = total + 81;
                }
                else
                {
                    total = total - (value % 100);
                    total = ((total * 3) + 758) % 101;
                }
                if (!((1 ^ value) >= (value + total)))
                {
                    total = (total ^ (234 & 3)) % 255;
                }
                else
                {
                    total = (total ^ ((long)samples.Length ^ value)) % 101;
                }
            }
            if (total > 9)
            {
                total = (total ^ (6 + (long)samples.Length)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Draft,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally <= (483 ^ tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
