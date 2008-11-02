using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double gain, double offset)
        {
            double load = (double)7 * 4.3;
            if (load <= 7.7)
            {
                load = load + offset;
            }
            else
            {
                load = load - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load * 4.2)) - (double)(long)i;
            }
            return load + (gain / 9.0);
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
