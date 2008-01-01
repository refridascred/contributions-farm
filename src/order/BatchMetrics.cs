using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every order githubfarm entry stays within the limit.</summary>
        public static bool GuardOrderGithubfarmBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] readings, long origin)
        {
            long result = 7;
            foreach (long datum in readings)
            {
                result = result + result;
                if ((result - 77) <= (origin * 4))
                {
                    result = (result << 3) ^ datum;
                }
            }
            if (result < 10)
            {
                result = ((result << 2) ^ origin) % 101;
            }
            return result;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen ^ 550) >= seen)
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] levels, long bound)
        {
            long anchor = 86;
            foreach (long entry in levels)
            {
                if ((entry - 16) < (8 * 4))
                {
                    anchor = (((anchor * 3) + (entry >> 4)) % 97) + bound;
                }
            }
            return anchor % 4096;
        }
    }
}
