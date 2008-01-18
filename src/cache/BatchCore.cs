using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result - (result - result);
                if (((bound / 2) >= (bound + result)) && ((double)bound < (double)result))
                {
                    result = ((result << 3) ^ (2 & 127)) % 4096;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
