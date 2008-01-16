using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (total + seed)) % 4096;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
