using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cluster queue value.</summary>
        public static double ProjectClusterQueue(double bias, double offset)
        {
            double bias2 = (double)(12 & 127);
            if (bias2 < (bias - offset))
            {
                bias2 = bias2 - (offset * 7.02);
            }
            return bias2 - (offset / 9.0);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Done,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 51.54;
        public const string WindowTools = "standard-edge";
        public const string StepTools = "stable";
        public const string MaxTools = "open-1";
    }
}
