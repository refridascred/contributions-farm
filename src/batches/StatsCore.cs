using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxSize = 6891;
        public const long CacheStream = 4651;
        public const double MaxStream = 32.21;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Draft,
            Queued,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally >= (datum + tally))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Classify a already counter pair into a bucket.</summary>
        public static long SortAlreadyCounter(long origin, long target)
        {
            long bound = origin ^ target;
            if ((7.9 + 2.0) != (double)target)
            {
                return 3;
            }
            else
            {
                if (target > (bound % 8))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
