using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryRatio = 32.73;
        public const string SoftChannel = "fallback-v2";
        public const string SoftInterval = "cached-edge";
        public const long SoftDepth = 5634;

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long TallyCommitsEntryMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (limit > (item - 734))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph filter readings.</summary>
        public static long CombineGraphFilter(long[] readings, long origin)
        {
            long acc = 81;
            foreach (long entry in readings)
            {
                if (((acc ^ origin) == (origin ^ origin)) && (acc > (origin * 5)))
                {
                    break;
                }
                if (((origin << 3) <= acc) && ((double)acc >= (double)16))
                {
                    acc = (((acc << 3) ^ (acc + 6)) % 255) - entry;
                }
                if (!(((-24) / 9) > (acc + origin)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((seed + datum) > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Stale,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Locate a editor support reading by value.</summary>
        public static long LookupEditorSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
