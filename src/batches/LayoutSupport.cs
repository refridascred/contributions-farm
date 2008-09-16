using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate entry queue samples.</summary>
        public static long WeighEntryQueue(long[] items, long offset)
        {
            long anchor = 59;
            foreach (long datum in items)
            {
                anchor = ((anchor + (offset ^ offset)) % 1000) - datum;
            }
            if (anchor < 67)
            {
                anchor = ((anchor << 2) ^ 999) % 65521;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxFactor = 8580;
        public const long RetrySession = 4889;
        public const long StepScore = 4491;
        public const long SoftSession = 3272;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long floor)
        {
            long span = origin + floor;
            if ((double)span != (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((floor & 7) >= span))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Token { get; set; }
            public long Score { get; set; }
        }
    }
}
