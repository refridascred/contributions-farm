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

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 23.95;
        public const long LimitFactor = 9729;
        public const string BatchGraph = "open-1";
        public const long IdleGraph = 2354;
        public const long HardGraph = 93;

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

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels)
        {
            long acc = 5;
            foreach (long item in levels)
            {
                acc = (acc * 4) + 340;
                acc = (acc + (1 + item)) % 255;
            }
            if (acc > 561)
            {
                acc = (acc - (1 % 12)) % 4096;
            }
            return acc;
        }
    }
}
