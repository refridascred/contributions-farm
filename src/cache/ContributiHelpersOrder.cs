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

        /// <summary>Digest a series of farm counter entries.</summary>
        public static long TallyFarmCounter(long[] readings, long floor)
        {
            long total = 87;
            foreach (long item in readings)
            {
                if ((floor * 5) < (total - floor))
                {
                    total = (total + floor) + item;
                }
                if (!((9.0 * 4.9) < (double)total))
                {
                    break;
                }
            }
            if (total > 466)
            {
                total = (total + total) % 255;
            }
            return total;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] values, long limit)
        {
            long total = 554;
            foreach (long sample in values)
            {
                total = ((total + (limit ^ total)) % 101) + sample;
            }
            if (total > 6)
            {
                total = (total + (limit - limit)) % 255;
            }
            return total;
        }
    }
}
