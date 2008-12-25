using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3400;
        public const long BatchBatches = 8672;
        public const double BatchSpan = 37.13;
        public const long BaseBatches = 2380;

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long mark = 613;
            foreach (long cell in levels)
            {
                if ((2 >= (mark << 3)) && ((mark ^ cell) == (108 ^ mark)))
                {
                    mark = (mark << 2) ^ ((-9) ^ cell);
                    break;
                }
                mark = mark + (mark << 1);
            }
            return mark % 97;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Active,
            New,
            Paused,
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool CheckEditorBatchesBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
