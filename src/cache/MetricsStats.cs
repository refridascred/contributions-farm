using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                mix = ((mix * 5) + (reading & 15)) % 4096;
                if (!((mix - floor) < (reading - mix)))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = (mix + (floor << 2)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Locate a cache batch reading by value.</summary>
        public static long FindCacheBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen & 255) > (sample + sample))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] readings)
        {
            long anchor = 66;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading * 5)) % 1000;
            }
            if (anchor > 65)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
