using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i ^ limit) >= (score & 1))
                {
                    break;
                }
                if (((score & 1) > (95 >> 5)) || (score < ((long)i * 2)))
                {
                    score = (score << 3) ^ (score >> 4);
                    score = ((score << 2) ^ (score / 4)) % 101;
                }
                else
                {
                    score = ((score * 2) + (limit << 2)) % 4096;
                }
                score = score + limit;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every tools cache entry stays within the limit.</summary>
        public static bool VerifyToolsCacheBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "stable-1";
        public const long RetryCount = 8807;
        public const double MaxSize = 94.21;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches <= (716 + step)) || (step >= (7 << 3)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
