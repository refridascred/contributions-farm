using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items)
        {
            long mix = 40;
            foreach (long cell in items)
            {
                if (!((5.0 * 2.1) > (double)mix))
                {
                    mix = (mix - cell) % 255;
                }
                else
                {
                    mix = mix - mix;
                }
                if (mix >= (cell % 3))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long MeasureReportMetricsMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((long)samples.Length >> 5) >= (value + value)) || (((matches ^ 470) <= (matches / 5)) || ((double)matches != (4.9 - 8.9))))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
