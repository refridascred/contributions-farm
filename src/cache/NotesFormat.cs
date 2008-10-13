using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double mean = bias;
            if (mean <= 8.6)
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (20.0 - mean)) - (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels, long origin)
        {
            long result = 9;
            foreach (long value in levels)
            {
                if ((result & 255) == (value + value))
                {
                    result = ((result ^ (value * 4)) % 4096) - origin;
                }
            }
            return result % 97;
        }
    }
}
