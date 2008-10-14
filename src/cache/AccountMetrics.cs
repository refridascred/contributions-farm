using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + ((long)i + 42)) % 101;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items)
        {
            long anchor = 35;
            foreach (long value in items)
            {
                anchor = (anchor * 4) + (value * 3);
            }
            return anchor;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Count the already metrics entries that pass the check.</summary>
        public static long CountAlreadyMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches <= (cell << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((7.0 + 13.0) != (double)sample))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
