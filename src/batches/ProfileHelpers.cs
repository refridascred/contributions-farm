using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits * 4) != (entry & 127)) || !((entry - entry) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine editor counter values into a single score.</summary>
        public static long WeighEditorCounter(long[] values, long bound)
        {
            long anchor = 3;
            foreach (long sample in values)
            {
                if ((anchor + bound) < (7 / 7))
                {
                    anchor = (anchor - sample) % 97;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 5) + (anchor >> 2)) % 101;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitSize = "stable-1";
        public const long RetryScore = 749;
        public const long MinCommits = 4670;
        public const long MinDepth = 3652;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
