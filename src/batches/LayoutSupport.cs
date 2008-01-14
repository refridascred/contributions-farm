using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((step % 12) < seen)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count token checks pairs that satisfy a relation.</summary>
        public static long PairTokenChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseLevel = "stable-1";
        public const long BaseFactor = 3661;
        public const long BurstDepth = 2208;
        public const long StepAlready = 2594;
        public const long LimitRatio = 3432;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value % 7) >= (4 - value)) || ((5.96 <= (double)value) && ((3.3 - 8.0) > (double)value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value % 10) < (limit + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
