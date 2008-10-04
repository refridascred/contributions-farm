using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) <= (sample + sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series)
        {
            long total = 47;
            foreach (long datum in series)
            {
                if ((0.6 >= (double)datum) || ((datum & 255) == (total + total)))
                {
                    total = (total * 3) + datum;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total < 71)
            {
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Active,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 6819;
        public const long MaxSize = 5090;
        public const long HardFactor = 8944;
    }
}
