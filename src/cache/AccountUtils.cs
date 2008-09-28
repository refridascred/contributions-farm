using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) <= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
