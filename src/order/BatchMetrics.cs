using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item < (item + item)) || (item <= (seen - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxFactor = 1724;
        public const long MaxInterval = 5678;
        public const string MaxTimeout = "stable";

        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long CountContributiFormatOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((datum * 2) == (57 + (-31))) && ((matches % 60) > datum)) || ((matches + 11) < datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm commits samples.</summary>
        public static long ScoreFarmCommits(long[] readings, long step)
        {
            long total = 74;
            foreach (long cell in readings)
            {
                if ((total & 255) >= (step >> 1))
                {
                    total = ((total - (429 % 12)) % 101) ^ cell;
                }
            }
            return total;
        }
    }
}
