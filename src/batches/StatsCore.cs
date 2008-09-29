using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool GuardCommitsRecordBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally & 1) > entry) || !((17 << 3) != (tally ^ 506)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowCount = 6891;
        public const long WindowSpan = 6072;
        public const long CacheLevel = 6999;
        public const string BaseAlready = "latest-v2";
        public const string SoftRatio = "primary";

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long bound, long bound2)
        {
            long prev = bound - bound2;
            if ((bound - prev) <= prev)
            {
                return 5;
            }
            else
            {
                if (bound2 <= (bound % 16))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
