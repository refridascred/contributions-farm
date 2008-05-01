using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session notes entries that pass the check.</summary>
        public static long AuditSessionNotesMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally & 63) >= (0 ^ datum))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate cache format readings against a bound.</summary>
        public static bool VerifyCacheFormatRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen + seen) < 657) && (seen < (seen % 64)))
                {
                    seen = ((seen + 1) ^ datum) + bound;
                }
            }
            return seen;
        }
    }
}
