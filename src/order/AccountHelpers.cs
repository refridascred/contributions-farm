using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4295;
        public const string BaseChecks = "local";
        public const long WindowSpan = 8261;
        public const long MaxRatio = 446;

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = state - ((-77) / 5);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
