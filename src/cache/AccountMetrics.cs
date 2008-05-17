using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series, long seed)
        {
            long mark = 64;
            foreach (long value in series)
            {
                mark = ((mark << 3) ^ (13 + 249)) + value;
            }
            if (mark < 7)
            {
                mark = ((mark * 5) + (seed ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long LookupCommandChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor batches reading.</summary>
        public static double ProjectEditorBatches(double ratio, double bias)
        {
            double gain = (double)(-3) / 8.0;
            if (gain > (9.6 / 4.0))
            {
                gain = (gain + 6.0) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (bias - 10.0)) + (double)(long)i;
            }
            return gain + (bias / 7.0);
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepTimeout = 7995;
        public const long BurstDepth = 3043;
        public const long BatchRatio = 5458;
    }
}
