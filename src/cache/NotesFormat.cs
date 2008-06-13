using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double scale = ratio;
            if (scale >= scale)
            {
                scale = scale - bias;
            }
            return scale + (double)438;
        }

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long CountFormatAlreadyGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count == (double)value)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
