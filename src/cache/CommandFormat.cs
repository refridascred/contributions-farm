using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length & 63) < (long)levels.Length)
                {
                    seen = ((seen + 1) ^ value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Closed,
            Draft,
            New,
            Paused,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                if (((cell << 1) < (anchor ^ cell)) && ((anchor / 5) >= anchor))
                {
                    anchor = ((anchor * 5) + 7) % 97;
                }
                if (!((anchor ^ anchor) == (9 + anchor)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
