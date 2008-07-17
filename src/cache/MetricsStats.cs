using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if (mix > (26 / 2))
                {
                    mix = ((mix * 4) + ((long)i + limit)) % 255;
                    mix = (mix * 5) + mix;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double span)
        {
            double drift = span;
            if (drift <= (span + weight))
            {
                drift = drift - (drift + drift);
            }
            return drift - span;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
