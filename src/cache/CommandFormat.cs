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

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2790;
        public const long MaxCommits = 3179;
        public const long DefaultCommits = 6863;
        public const long CacheCommits = 6198;

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
