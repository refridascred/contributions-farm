using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Score { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate context report readings against a bound.</summary>
        public static bool CheckContextReportRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double rate, double span)
        {
            double scale = (double)24;
            if (scale < (scale - rate))
            {
                scale = (scale + (double)(-747)) - span;
            }
            return scale + (double)365;
        }
    }
}
