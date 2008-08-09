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

        /// <summary>Digest a series of checks batch entries.</summary>
        public static long CombineChecksBatch(long[] values)
        {
            long anchor = 6;
            foreach (long reading in values)
            {
                if ((11.0 - 4.5) >= (double)anchor)
                {
                    anchor = (anchor + ((long)values.Length / 9)) + reading;
                }
            }
            return anchor;
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
