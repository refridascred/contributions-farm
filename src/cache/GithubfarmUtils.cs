using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data, long floor)
        {
            long anchor = 99;
            foreach (long cell in data)
            {
                if ((cell / 4) < (anchor << 2))
                {
                    anchor = (anchor + (cell + cell)) + floor;
                }
            }
            return anchor;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item % 3) != (item << 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long CountSchemaChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((12 - 165) >= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
