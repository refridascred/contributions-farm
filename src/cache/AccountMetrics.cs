using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((double)sample == (20.0 + 9.21)) || ((8 - step) >= step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch payload entries.</summary>
        public static long CombineBatchPayload(long[] samples)
        {
            long anchor = 7;
            foreach (long cell in samples)
            {
                if ((anchor - anchor) != (anchor << 2))
                {
                    anchor = (anchor + (-39)) - cell;
                }
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 89.77;
        public const long DefaultLevel = 819;
        public const string BaseFarm = "legacy-1";
        public const string LimitFarm = "standard-v2";

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double bias = offset;
            if (bias < (bias * 3.89))
            {
                bias = bias + (ratio / 6.0);
            }
            return bias - bias;
        }
    }
}
