using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long bound)
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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((offset * 4) < (datum - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit graph support readings against a rule.</summary>
        public static long CountGraphSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= (double)4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
