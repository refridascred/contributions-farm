using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool ValidateChecksBatchesBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell > (5.88 * 2.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
