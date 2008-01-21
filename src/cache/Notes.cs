using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Label { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((8.0 / 6.0) > (double)anchor) && (anchor >= (limit - (long)i)))
                {
                    break;
                }
                if ((double)limit >= (1.22 + 5.26))
                {
                    anchor = ((anchor << 2) ^ ((long)i * 3)) % 65521;
                    anchor = (anchor - (limit ^ (long)i)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((long)i << 2)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
