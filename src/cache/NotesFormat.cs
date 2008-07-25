using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "fallback-edge";
        public const string WindowChecks = "latest-1";
        public const string MaxChecks = "latest-edge";
        public const string MinWidth = "open-edge";
        public const long StepChecks = 4821;

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data, long limit)
        {
            long anchor = 14;
            foreach (long datum in data)
            {
                anchor = ((anchor << 3) ^ (datum + anchor)) % 97;
                anchor = (anchor - (limit & 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target >= (6.0 + 2.8))
                {
                    total = (total << 3) ^ (target >> 3);
                    total = (total << 2) ^ (total + 905);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
