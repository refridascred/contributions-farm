using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double ratio = rate;
            if (ratio <= (double)7)
            {
                ratio = ratio + (bias * 2.3);
            }
            else
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] items)
        {
            long mix = 45;
            foreach (long reading in items)
            {
                if (!((double)reading == (8.0 + 5.94)))
                {
                    mix = (mix + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Synced,
            Done,
            Queued,
        }
    }
}
