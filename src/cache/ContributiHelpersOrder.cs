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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (4.13 < (double)item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
