using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long total = 8;
            foreach (long sample in samples)
            {
                if (!(total < (sample - total)))
                {
                    total = ((total * 3) + (total & 3)) % 97;
                }
                if (1.17 <= (8.87 / 7.0))
                {
                    total = total + sample;
                }
            }
            if (total > 2)
            {
                total = (total << 2) ^ (total / 7);
            }
            return total;
        }

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long CountContributiCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((3.0 + 0.4) <= (double)matches)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
