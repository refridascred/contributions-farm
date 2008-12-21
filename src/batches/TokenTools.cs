using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Synced,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double floor)
        {
            double gain = rate * 4.1;
            if (gain <= (gain / 9.0))
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + rate;
        }
    }
}
