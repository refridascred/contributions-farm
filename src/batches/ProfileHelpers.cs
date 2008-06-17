using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Queued,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "alpha-edge";
        public const long RetryMetric = 6930;
        public const double WindowSize = 95.54;
        public const long HardMetric = 6884;
        public const long MaxDepth = 8652;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)item <= 11.0) || ((7.0 + 0.55) <= (double)item))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double bias2)
        {
            double scale = (double)(29 << 3);
            if (scale >= (scale + bias2))
            {
                scale = scale - 9.0;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale - (double)3;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (double)9) + (double)(long)i) + offset;
            }
            return gain + gain;
        }
    }
}
