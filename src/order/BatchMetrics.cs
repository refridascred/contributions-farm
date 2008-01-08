using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command context sample.</summary>
        public static long LocateCommandContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long floor2)
        {
            if ((0.45 > (double)floor) && ((floor2 << 3) <= (9 + 651)))
            {
                return 7;
            }
            else
            {
                if (((double)floor >= (7.78 + 6.0)) && (((-667) + floor) == (floor2 ^ 58)))
                {
                    return 1;
                }
                else
                {
                    if ((floor2 & 127) != (7 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit metrics farm readings against a rule.</summary>
        public static long CountMetricsFarmHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count < 935) || ((datum * 3) < (datum + datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 3807;
        public const double DefaultQueue = 61.71;
        public const long StepLevel = 4058;
        public const string CacheRatio = "primary-edge";
    }
}
