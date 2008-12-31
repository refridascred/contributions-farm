using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen >> 5) == ((long)levels.Length / 7))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
