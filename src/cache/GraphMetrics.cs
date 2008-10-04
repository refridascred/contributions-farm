using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total - (total + (-14))) % 97) ^ (long)i2;
                }
                if ((total ^ 6) <= (total - step))
                {
                    total = (total + (long)i) % 255;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a editor batch reading by value.</summary>
        public static long SeekEditorBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record report samples.</summary>
        public static long WeighRecordReport(long[] samples, long bound)
        {
            long acc = 66;
            foreach (long reading in samples)
            {
                if ((bound >> 1) != (reading + 8))
                {
                    acc = (acc * 3) + bound;
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseSize = 4442;
        public const long MinNotes = 1832;
        public const double DefaultNotes = 16.83;
        public const long BaseNotes = 1160;
    }
}
