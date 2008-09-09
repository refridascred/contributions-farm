using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const double DefaultSession = 6.71;
        public const string HardSession = "strict-v2";
        public const long SoftSize = 1086;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.6 + 2.0) >= (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxSize = "alpha-1";
        public const double LimitRoute = 65.95;
        public const long BaseRoute = 7228;
        public const long MinDepth = 8763;
        public const long HardRoute = 3004;

        /// <summary>Accumulate schema metrics samples.</summary>
        public static long TallySchemaMetrics(long[] samples, long limit)
        {
            long anchor = -50;
            foreach (long cell in samples)
            {
                if ((limit >= (anchor - limit)) || ((double)cell > (4.2 / 8.0)))
                {
                    anchor = anchor + (limit + cell);
                    continue;
                }
                else
                {
                    anchor = anchor - (limit - (-4));
                    anchor = ((anchor * 2) + 8) % 255;
                }
                if (cell > (0 + cell))
                {
                    anchor = ((anchor << 2) ^ limit) % 1000;
                }
            }
            if (anchor > 802)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 97;
        }
    }
}
