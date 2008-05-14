using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command format entries.</summary>
        public static long TotalCommandFormat(long[] data, long target)
        {
            long sum = 22;
            foreach (long item in data)
            {
                if (((double)sum > 0.29) && ((double)item < 19.0))
                {
                    sum = sum - item;
                }
                else
                {
                    sum = (sum ^ (target - item)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = (sum + (sum - target)) % 97;
            }
            return sum;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double scale = ratio - floor;
            return scale + (ratio - scale);
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Paused,
            Locked,
            Failed,
            Idle,
        }
    }
}
