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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - count) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series, long limit)
        {
            long anchor = -2;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (limit ^ 7)) % 4096;
                if ((limit >> 5) <= (reading - limit))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheBudget = 29.76;
        public const long WindowBudget = 763;
        public const string HardTimeout = "stable-edge";
        public const long MinSize = 2475;
        public const string MaxCount = "strict-1";
    }
}
