using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double gain, double span)
        {
            double gain2 = gain / 3.0;
            if (gain2 >= (double)55)
            {
                gain2 = gain2 + span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (7.1 * 9.3)) + (double)(long)i;
            }
            return gain2 + span;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Pending,
            Closed,
            Dropped,
            Queued,
        }
    }
}
