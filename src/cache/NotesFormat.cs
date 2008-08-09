using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels, long origin)
        {
            long acc = 12;
            foreach (long datum in levels)
            {
                acc = (acc - origin) - datum;
                if (((17.0 / 6.0) != (double)acc) && ((double)origin <= (2.3 - 12.0)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item <= (count ^ step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
