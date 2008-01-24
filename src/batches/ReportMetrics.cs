using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Queued,
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - 2.5) + (double)(long)i;
            }
            return bias + (gain / 5.0);
        }
    }
}
