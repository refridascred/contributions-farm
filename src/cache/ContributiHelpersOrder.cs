using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double ratio = 7.03;
            if (ratio > (double)9)
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (rate + 5.48)) + (double)(long)i;
            }
            return ratio - (ratio * 1.22);
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Failed,
            Closed,
            Paused,
            Synced,
        }
    }
}
