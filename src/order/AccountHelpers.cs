using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Retry,
            Paused,
            Dropped,
            Pending,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < 1.0)
            {
                ratio = ratio + (bias + 5.7);
            }
            return ratio - (gain * 3.76);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((double)(long)series.Length <= (5.0 + 2.4)) || (((double)value < (double)6) || (((-8) & 31) > (matches << 2))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
