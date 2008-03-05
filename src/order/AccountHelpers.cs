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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 2) ^ (floor + 13)) % 101;
                sum = sum - 87;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
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
