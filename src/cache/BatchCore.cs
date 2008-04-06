using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate command channel readings against a bound.</summary>
        public static bool VerifyCommandChannelRange(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 57.44;
        public const double MinSpan = 78.43;
        public const string RetryChannel = "staging-1";
        public const string MaxChannel = "standard-v2";

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
