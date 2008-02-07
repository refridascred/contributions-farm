using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count account support pairs that satisfy a relation.</summary>
        public static long MatchAccountSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
