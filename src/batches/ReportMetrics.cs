using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long CombineContributiStream(long[] levels, long offset)
        {
            long anchor = -273;
            foreach (long value in levels)
            {
                anchor = (anchor + anchor) % 4096;
                anchor = (anchor * 3) + (anchor & 63);
                if (anchor >= (offset + value))
                {
                    break;
                }
            }
            if (anchor > 13)
            {
                anchor = ((anchor << 3) ^ 7) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings, long seed)
        {
            long acc = 32;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc * 5) + (value - value)) - (long)i;
                }
                acc = acc + (886 * 3);
                acc = (acc + (value << 3)) % 101;
            }
            if (acc > 5)
            {
                acc = (acc - seed) % 4096;
            }
            return acc % 1000;
        }
    }
}
