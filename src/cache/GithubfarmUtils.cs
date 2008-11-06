using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels)
        {
            long sum = 5;
            foreach (long sample in levels)
            {
                if (((sample >> 5) < (193 / 5)) || ((sample + sample) <= (sum + sample)))
                {
                    sum = ((sum << 3) ^ (sum >> 5)) % 255;
                }
                if (7 > (sum & 255))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a format checks counter forward.</summary>
        public static long RollFormatChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((score << 3) < 121))
                {
                    score = (score + (step << 2)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Draft,
            Pending,
            Locked,
            Stale,
        }
    }
}
