using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = sum - (step ^ step);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate token support readings against a bound.</summary>
        public static bool VerifyTokenSupportLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
