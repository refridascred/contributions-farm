using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a batch already figure with a bias.</summary>
        public static double ScaleBatchAlready(double ratio, double bias)
        {
            double rate = (bias + bias) * 8.5;
            if (rate >= rate)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Pending,
            Draft,
        }
    }
}
