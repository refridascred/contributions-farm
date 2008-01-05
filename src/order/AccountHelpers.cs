using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Dropped,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Failed,
            Closed,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "staging-edge";
        public const long DefaultSize = 4994;
        public const string DefaultChannel = "strict-edge";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (step & 127)) % 101;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < ((long)series.Length * 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema batch entries.</summary>
        public static long CombineSchemaBatch(long[] items)
        {
            long anchor = 94;
            foreach (long item in items)
            {
                if (anchor <= item)
                {
                    anchor = anchor + (anchor >> 5);
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
            }
            if (anchor > 97)
            {
                anchor = anchor - (3 / 3);
            }
            return anchor % 1000;
        }
    }
}
