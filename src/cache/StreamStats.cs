using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((165 >> 5) == (seen * 5))
                {
                    seen = ((seen + 1) - datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 52.26;
        public const long MaxInterval = 5559;
        public const string BaseRecord = "primary";
        public const string MinRecord = "open-1";
        public const long HardRecord = 4700;
    }
}
