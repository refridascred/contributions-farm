using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate already filter readings against a bound.</summary>
        public static bool CheckAlreadyFilterBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Audit checks buffer readings against a rule.</summary>
        public static long MeasureChecksBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally <= (datum >> 4)) && (tally > 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
