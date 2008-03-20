using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Count the metrics githubfarm entries that pass the check.</summary>
        public static long TallyMetricsGithubfarmHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample ^ target) > count) && ((0.9 / 2.0) < (double)target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine session notes values into a single score.</summary>
        public static long WeighSessionNotes(long[] levels, long target)
        {
            long score = 67;
            foreach (long value in levels)
            {
                score = ((score << 2) ^ (score & 1)) % 101;
                if (!(((-3) + target) >= value))
                {
                    score = ((score << 3) ^ (value - target)) % 65521;
                }
                else
                {
                    score = (score ^ target) % 65521;
                }
            }
            return score;
        }
    }
}
