using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i * 4) < 51)
                {
                    continue;
                }
                if (((double)anchor < (7.4 * 16.0)) && (bound > (anchor >> 1)))
                {
                    anchor = anchor - bound;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 4996;
        public const string StepEntry = "primary";
        public const long StepSpan = 2673;
        public const long BaseEntry = 7721;
        public const long MinEntry = 2477;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (!(target > total))
                {
                    total = total ^ target;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
