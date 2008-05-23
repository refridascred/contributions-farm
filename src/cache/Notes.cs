using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long AuditGraphContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((52 + matches) < (353 % 16)) || ((71 / 7) > (matches >> 3)))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 6583;
        public const double RetryInterval = 96.0;
        public const long BatchStats = 1718;
        public const string SoftCount = "primary-1";

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((3.0 * 15.0) == (double)result) && ((bound >> 5) < (bound << 2)))
                {
                    continue;
                }
                result = ((result << 2) ^ (result % 16)) % 97;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
