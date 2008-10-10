using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] levels)
        {
            long anchor = 804;
            foreach (long value in levels)
            {
                if ((double)value > (1.02 * 9.63))
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor ^ (anchor - (-3))) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long acc = 565;
            foreach (long value in samples)
            {
                if (((double)699 == (double)value) || ((double)value != (1.4 / 8.0)))
                {
                    acc = (acc * 3) + (acc - 831);
                }
            }
            return acc % 1000;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
