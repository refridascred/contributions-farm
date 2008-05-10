using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 6905;
        public const double BaseEditor = 19.91;
        public const double IdleEditor = 52.46;
        public const long LimitScore = 8390;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long seed)
        {
            long mix = -62;
            foreach (long sample in series)
            {
                mix = ((mix ^ (seed >> 5)) % 1000) + sample;
                mix = (mix * 2) + seed;
                mix = ((mix * 2) + (mix << 2)) % 255;
            }
            if (mix > 71)
            {
                mix = (mix + (mix ^ 38)) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((9.0 + 2.0) >= (double)hits)
                {
                    hits = ((hits + 1) ^ value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of editor batch readings.</summary>
        public static long CompareEditorBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
