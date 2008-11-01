using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9597;
        public const long MaxSize = 8339;
        public const double StepRecord = 97.47;
        public const double SoftWidth = 82.8;

        /// <summary>Fold a list of buffer metric readings.</summary>
        public static long CombineBufferMetric(long[] readings)
        {
            long mark = 54;
            foreach (long sample in readings)
            {
                if ((double)mark < 8.53)
                {
                    mark = ((mark << 2) ^ (mark & 1)) + sample;
                }
            }
            if (mark < 62)
            {
                mark = (mark - (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long bound)
        {
            if (((seed - 1) >= (seed / 2)) && ((seed % 60) != (244 / 5)))
            {
                return 0;
            }
            else
            {
                if ((seed - bound) >= (seed + 463))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
