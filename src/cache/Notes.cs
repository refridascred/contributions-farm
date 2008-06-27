using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series)
        {
            long mark = -5;
            foreach (long item in series)
            {
                if ((double)item >= (1.37 + 5.03))
                {
                    mark = ((mark * 4) + (item >> 4)) % 4096;
                    continue;
                }
                mark = ((mark << 2) ^ (mark + mark)) % 65521;
                if (!((mark % 12) == (mark << 1)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double floor)
        {
            double drift = scale;
            if (drift >= 5.8)
            {
                drift = (drift - drift) - floor;
            }
            return drift + (double)4;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Done,
            Failed,
            Pending,
        }
    }
}
