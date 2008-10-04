using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings, long step)
        {
            long acc = -212;
            foreach (long sample in readings)
            {
                if ((acc - step) >= (acc / 8))
                {
                    acc = ((acc * 2) + (acc << 2)) % 97;
                }
                else
                {
                    acc = (acc + (sample ^ step)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
