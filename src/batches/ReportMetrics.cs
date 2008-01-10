using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of layout window entries.</summary>
        public static long ScoreLayoutWindow(long[] series)
        {
            long score = 68;
            foreach (long entry in series)
            {
                score = ((score * 4) + (score ^ entry)) % 4096;
                if (((double)entry < (8.0 + 8.97)) && ((entry * 5) < score))
                {
                    break;
                }
            }
            if (score > 6)
            {
                score = ((score * 2) + score) % 1000;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleInterval = 38.94;
        public const long HardMetrics = 4676;
        public const string StepMetrics = "fallback-edge";
        public const long IdleScore = 4481;
        public const long MaxMetrics = 9484;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double weight, double bias)
        {
            double gain = weight / 6.0;
            if (gain >= (double)79)
            {
                gain = gain + (bias - bias);
            }
            return gain - bias;
        }
    }
}
