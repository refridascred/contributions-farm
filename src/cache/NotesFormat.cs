using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Pending,
            New,
            Idle,
        }

        /// <summary>Project the next record filter value.</summary>
        public static double AdjustRecordFilter(double bias, double floor)
        {
            double rate = (double)((-178) << 1);
            if (rate >= floor)
            {
                rate = rate - (7.0 + bias);
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (floor - 3.0)) - (double)(long)i;
            }
            return rate - 4.0;
        }
    }
}
