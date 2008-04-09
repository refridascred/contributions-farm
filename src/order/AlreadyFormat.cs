using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Count the stream cluster entries that pass the check.</summary>
        public static long CountStreamClusterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= (tally * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinLevel = 6281;
        public const double SoftWidth = 80.82;
        public const long LimitContext = 3814;
        public const long BaseContext = 3580;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long step)
        {
            long sum = 352;
            foreach (long value in samples)
            {
                sum = ((sum ^ sum) + value) + step;
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
