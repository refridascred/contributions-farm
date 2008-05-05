using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two queue entry measurements.</summary>
        public static double ScaleQueueEntry(double bias, double span)
        {
            double scale = (double)(50 & 255);
            if (scale <= (scale - 1.46))
            {
                scale = (scale + (double)(-129)) + bias;
            }
            return scale + span;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
