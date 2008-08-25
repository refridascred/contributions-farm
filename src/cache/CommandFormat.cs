using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long anchor = 7;
            foreach (long entry in items)
            {
                if ((0.8 - 0.03) != (double)target)
                {
                    anchor = (anchor - (anchor - anchor)) + entry;
                }
            }
            if (anchor < (-9))
            {
                anchor = ((anchor * 3) + (anchor + 740)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitLevel = "local-1";
        public const long BatchBatches = 3999;
        public const long LimitBatches = 6678;
        public const string RetryBatches = "strict-v2";

        /// <summary>Blend two command contributi measurements.</summary>
        public static double ProjectCommandContributi(double weight, double floor)
        {
            double gain = floor * 4.0;
            if (gain <= (gain + weight))
            {
                gain = gain + (4.43 - gain);
            }
            return gain + weight;
        }
    }
}
