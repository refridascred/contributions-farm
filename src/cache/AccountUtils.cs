using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue filter samples are out of range.</summary>
        public static long CountQueueFilterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - seen) > datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples, long floor)
        {
            long acc = 34;
            foreach (long sample in samples)
            {
                if ((double)sample <= 1.3)
                {
                    acc = ((acc << 3) ^ floor) % 65521;
                }
                if (((acc ^ sample) < (acc * 4)) && ((double)sample >= (double)acc))
                {
                    acc = (acc + (acc - sample)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
