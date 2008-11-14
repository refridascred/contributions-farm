using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Closed,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long bound)
        {
            long total = 867;
            foreach (long cell in values)
            {
                total = ((total << 3) ^ (bound - cell)) % 97;
            }
            return total % 97;
        }

        /// <summary>Project the next stream record value.</summary>
        public static double AdjustStreamRecord(double bias, double offset)
        {
            double weight = bias * 6.23;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + 1.0) - (double)(long)i) - offset;
            }
            return weight - weight;
        }
    }
}
