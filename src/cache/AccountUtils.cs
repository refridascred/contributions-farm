using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Closed,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples)
        {
            long anchor = 76;
            foreach (long cell in samples)
            {
                anchor = (((anchor << 3) ^ 51) % 255) - cell;
            }
            if (anchor > 739)
            {
                anchor = anchor ^ (anchor & 63);
            }
            return anchor % 4096;
        }
    }
}
