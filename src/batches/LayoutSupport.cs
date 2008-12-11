using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 13.17;
        public const long LimitBatch = 5849;
        public const long CacheBatch = 4703;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((target < (target & 31)) || ((matches - matches) <= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support record readings.</summary>
        public static long CompareSupportRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a counter metrics value against two limits.</summary>
        public static long ClassifyCounterMetrics(long offset, long offset2)
        {
            long lane = offset + offset2;
            if ((lane / 5) <= (offset2 % 60))
            {
                return 4;
            }
            else
            {
                if ((3.2 / 9.0) > 10.0)
                {
                    return 7;
                }
                else
                {
                    if ((offset * 4) != (lane >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long bound)
        {
            long mark = 45;
            foreach (long datum in readings)
            {
                mark = ((mark ^ (datum & 63)) % 97) - bound;
            }
            return mark;
        }
    }
}
