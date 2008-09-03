using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "open-edge";
        public const double BurstContributi = 87.21;
        public const double MinContributi = 52.07;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches + matches) >= (seed + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long offset, long step)
        {
            if ((double)step >= (14.0 + 1.01))
            {
                return 0;
            }
            else
            {
                if ((step - offset) > offset)
                {
                    return 3;
                }
                else
                {
                    if (step < (offset - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double scale = ratio;
            if (scale <= 8.98)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (2.63 - bias)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
