using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (7 <= (matches * 4))
                {
                    matches = ((matches + 3) ^ sample) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Derive the next payload editor value from a seed.</summary>
        public static long StepPayloadEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 3) ^ (origin * 5)) % 101;
                if ((double)(long)i >= (double)origin)
                {
                    sum = sum ^ (41 + sum);
                }
                else
                {
                    sum = ((sum * 2) + (sum / 9)) % 255;
                    sum = sum - origin;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
