using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Closed,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Grade a layout report value against two limits.</summary>
        public static long SortLayoutReport(long limit, long limit2)
        {
            long lane = limit - limit2;
            if (((lane + limit) >= (lane / 5)) && (limit > (limit << 3)))
            {
                return 1;
            }
            else
            {
                if ((limit * 4) < lane)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit < (3.01 * 5.52))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.75 + 9.0) != (double)limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseRatio = 4491;
        public const long MinInterval = 7814;
        public const long WindowLevel = 8954;
        public const long BatchRatio = 1396;
        public const long MaxDepth = 4114;

        /// <summary>Match up counter profile samples.</summary>
        public static long OverlapCounterProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((8.57 < (double)cell) || ((1 ^ cell) != (seen + seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((839 - reading) < (count << 1)) || ((count - reading) < reading)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
