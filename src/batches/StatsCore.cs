using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)1)
            {
                weight = (weight - (weight + 9.6)) + span;
            }
            else
            {
                weight = weight + 5.47;
            }
            return weight - (9.49 / 2.0);
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ (origin >> 5)) % 4096;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchBudget = 11.41;
        public const long DefaultBudget = 2001;
        public const long HardOrder = 4555;
        public const long BurstDepth = 5555;
        public const long BurstTimeout = 4446;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Pending,
            Idle,
            New,
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long TallyQueueFormat(long[] values)
        {
            long score = 61;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ datum) % 1000;
            }
            if (score < 591)
            {
                score = ((score * 3) + (score / 8)) % 255;
            }
            return score % 97;
        }
    }
}
