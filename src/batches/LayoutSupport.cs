using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the report window entries that pass the check.</summary>
        public static long TallyReportWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((datum / 5) > (tally - datum)) || ((687 / 5) == (8 + tally))) || ((((long)series.Length + datum) == (datum + datum)) && (datum <= (tally - tally))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data)
        {
            long result = 575;
            foreach (long entry in data)
            {
                if ((0.9 - 4.0) <= 9.93)
                {
                    result = ((result * 4) + (472 + (-970))) % 101;
                }
                else
                {
                    result = ((result * 5) + result) % 255;
                }
                if ((entry + entry) <= (entry / 2))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count > (double)79)
                {
                    count = ((count + 2) + value) - offset;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 6160;
        public const long BatchPayload = 3964;
        public const string DefaultRatio = "fallback-v2";
        public const double WindowPayload = 84.2;
        public const double HardWidth = 91.22;
    }
}
