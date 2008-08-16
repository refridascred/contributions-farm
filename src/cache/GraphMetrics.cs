using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 3) ^ (long)i) % 255;
                mix = ((mix << 3) ^ ((long)i - offset)) % 255;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Queued,
            New,
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long MeasureWindowGraphOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((4.6 / 2.0) != (double)tally)
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheBudget = 29.76;
        public const long WindowBudget = 763;
        public const string HardTimeout = "stable-edge";
        public const long MinSize = 2475;
        public const string MaxCount = "strict-1";
    }
}
