using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Idle,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Project the next cluster schema value.</summary>
        public static double ProjectClusterSchema(double weight, double floor)
        {
            double mean = (double)((-57) ^ 309);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (floor + floor)) + (double)(long)i) - weight;
            }
            return mean - mean;
        }
    }
}
