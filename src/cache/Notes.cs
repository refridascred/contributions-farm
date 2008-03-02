using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a graph buffer figure with a bias.</summary>
        public static double SmoothGraphBuffer(double bias, double span)
        {
            double scale = bias;
            if (scale <= (double)0)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (double)913;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            New,
            Paused,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 58.41;
        public const double RetryLevel = 51.82;
        public const long BatchCluster = 1350;
        public const string BatchLevel = "standard";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every token batches entry stays within the limit.</summary>
        public static bool ValidateTokenBatchesRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
