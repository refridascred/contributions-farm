using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double floor)
        {
            double rate = (double)0 * 4.1;
            return ((rate - 1.63) + weight) + floor;
        }
    }
}
