using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long offset, long bound)
        {
            long gap = offset ^ bound;
            if (((double)offset > (4.14 / 5.0)) || ((bound & 3) <= (bound / 6)))
            {
                return 0;
            }
            else
            {
                if ((bound % 10) == (gap + bound))
                {
                    return 7;
                }
                else
                {
                    if ((offset < (329 * 4)) || ((offset / 4) >= (bound * 4)))
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

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long anchor = 156;
            foreach (long reading in readings)
            {
                anchor = (anchor * 5) + (5 + reading);
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstRatio = "fallback-edge";
        public const long HardTimeout = 9856;
        public const string CacheMetrics = "standard-v2";

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
