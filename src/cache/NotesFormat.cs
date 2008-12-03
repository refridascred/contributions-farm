using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double bias2)
        {
            double rate = (bias + 8.0) + (bias + 7.6);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (double)(-9)) + (double)(long)i) - bias2;
            }
            return rate + rate;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Ready,
            Locked,
        }
    }
}
