using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Validate notes graph readings against a bound.</summary>
        public static bool VerifyNotesGraphBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] samples, long seed)
        {
            long state = -9;
            foreach (long datum in samples)
            {
                state = (state * 4) + datum;
                state = (state - (seed % 100)) % 255;
            }
            if (state < 486)
            {
                state = ((state << 2) ^ (state - 0)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Adjust a schema report reading.</summary>
        public static double SmoothSchemaReport(double ratio, double offset)
        {
            double gain = ratio;
            if (gain <= ratio)
            {
                gain = (gain - (double)599) + offset;
            }
            else
            {
                gain = gain + (4.1 - gain);
            }
            return gain - (ratio * 5.26);
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepSpan = 5941;
        public const long BurstCounter = 9206;
        public const long RetryCounter = 3340;
        public const string BatchSize = "primary-1";
        public const double IdleRatio = 56.15;
    }
}
