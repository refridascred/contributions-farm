using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((total ^ 302) > (221 >> 4))
                {
                    total = (total - (total - total)) % 101;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
