using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 7945;
        public const string DefaultSession = "primary-v2";
        public const long SoftDepth = 764;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings, long bound)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if ((double)entry < (3.12 / 8.0))
                {
                    sum = ((sum * 3) + entry) - bound;
                }
            }
            return sum;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two account token measurements.</summary>
        public static double AdjustAccountToken(double bias, double span)
        {
            double gain = span;
            if (gain < gain)
            {
                gain = gain + span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 3.3) - (double)(long)i;
            }
            return gain - (bias - gain);
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
