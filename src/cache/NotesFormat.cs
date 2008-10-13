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

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long acc = 76;
            foreach (long sample in readings)
            {
                acc = (acc + (acc - sample)) % 97;
            }
            if (acc < 0)
            {
                acc = acc ^ (acc / 8);
            }
            return acc;
        }
    }
}
