using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double mean = scale / 8.0;
            if (mean > scale)
            {
                mean = (mean - 2.0) + span;
            }
            else
            {
                mean = mean + (10.0 - mean);
            }
            return mean - mean;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "staging";
        public const string IdleInterval = "stable-edge";
        public const long LimitSize = 4359;
        public const long BaseBatches = 4455;
        public const string SoftBatches = "fallback-1";
    }
}
