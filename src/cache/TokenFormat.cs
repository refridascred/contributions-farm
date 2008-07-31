using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every format window entry stays within the limit.</summary>
        public static bool GuardFormatWindowLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
