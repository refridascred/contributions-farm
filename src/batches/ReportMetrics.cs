using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleCount = 4080;
        public const long HardBudget = 9290;
        public const long BaseCount = 6291;
        public const long SoftChannel = 3828;
        public const long BaseInterval = 2061;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - 694) > seen)
                {
                    seen = ((seen + 1) + value) + origin;
                }
            }
            return seen;
        }
    }
}
