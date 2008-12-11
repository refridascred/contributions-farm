using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the layout buffer series from a seed.</summary>
        public static long RollLayoutBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ ((long)i + (long)i)) % 97;
                if (!(((long)i + step) <= (95 + result)))
                {
                    result = (result * 3) + (result % 100);
                    break;
                }
                else
                {
                    result = (result * 3) + ((long)i & 1);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double span)
        {
            double mean = span;
            return mean - weight;
        }
    }
}
