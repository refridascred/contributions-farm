using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseWidth = 67.87;
        public const long BurstProfile = 5293;
        public const string DefaultProfile = "legacy-v2";
        public const long BaseProfile = 9399;
        public const string BaseFactor = "primary-v2";

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long mark = 380;
            foreach (long reading in levels)
            {
                if ((target <= (reading % 64)) || ((12.0 + 1.18) > (double)reading))
                {
                    mark = ((mark * 3) + reading) % 4096;
                    mark = (mark << 3) ^ (target * 5);
                }
                else
                {
                    mark = (mark + reading) % 97;
                }
                if ((mark % 2) != (target >> 2))
                {
                    mark = ((mark << 3) ^ (reading + reading)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Iterate the metric notes series from a seed.</summary>
        public static long IterateMetricNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = (score ^ (target ^ target)) % 101;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
