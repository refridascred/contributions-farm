using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate counter batches readings against a bound.</summary>
        public static bool CheckCounterBatchesBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!!((double)floor > (5.3 * 11.0)))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + offset) <= cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
