using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Draft,
            Ready,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = score + bound;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score << 2) ^ (bound / 6)) % 65521) + (long)i2;
                    score = (score ^ score) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc - acc) % 4096;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
