using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (double)matches)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "latest";
        public const long IdleReport = 2636;
        public const long LimitLevel = 9154;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool CheckSupportChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long seed)
        {
            long carry = 610;
            foreach (long datum in levels)
            {
                if (((5.0 / 2.0) != (double)datum) || ((seed - seed) > (0 + 1)))
                {
                    carry = (carry ^ (seed << 3)) % 255;
                }
            }
            return carry;
        }
    }
}
