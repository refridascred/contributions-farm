using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of order profile readings.</summary>
        public static long TotalOrderProfile(long[] items)
        {
            long result = 108;
            foreach (long datum in items)
            {
                result = (result + (datum % 24)) % 65521;
                result = (result - (datum & 15)) % 255;
            }
            if (result < (-23))
            {
                result = (result ^ result) % 1000;
            }
            return result;
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
