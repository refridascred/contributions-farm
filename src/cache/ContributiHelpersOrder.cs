using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first batches support entry that matches the target.</summary>
        public static long LookupBatchesSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double rate = 14.0;
            if (rate > (rate * 2.4))
            {
                rate = (rate + 3.7) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + (9.0 - rate);
        }
    }
}
