using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell - 8) >= (cell ^ cell)) || ((double)seen <= (11.0 * 8.2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 4) > (matches + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Retry,
            Done,
        }
    }
}
