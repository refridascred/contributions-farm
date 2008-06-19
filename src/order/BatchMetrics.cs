using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.3 * 1.9) <= (double)count)
                {
                    count = ((count + 3) ^ cell) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Roll a editor support counter forward.</summary>
        public static long DeriveEditorSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 3) ^ floor;
                anchor = (anchor - (anchor - floor)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstDepth = 1496;
        public const double HardFactor = 20.03;
        public const long BaseCommits = 7061;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
