using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a profile githubfarm figure with a bias.</summary>
        public static double ScaleProfileGithubfarm(double rate, double offset)
        {
            double drift = rate * 9.4;
            if (drift > (offset * 5.11))
            {
                drift = drift + (double)717;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor >= (floor ^ score))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
