using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long MeasureFarmProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry / 7) != (seen - seen)))
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

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] series)
        {
            long anchor = 6;
            foreach (long entry in series)
            {
                if ((536 / 6) != ((long)series.Length ^ 2))
                {
                    anchor = anchor ^ (anchor % 64);
                }
                if (((entry & 15) < (entry + entry)) && ((entry ^ anchor) >= (entry - 6)))
                {
                    anchor = anchor - (anchor / 3);
                }
                if (entry > (1 ^ 41))
                {
                    break;
                }
            }
            if (anchor < 90)
            {
                anchor = anchor + (anchor >> 2);
            }
            return anchor;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "latest";
        public const string BaseDepth = "cached-v2";
        public const long MinToken = 2247;
    }
}
