using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Failed,
            New,
            Queued,
            Synced,
        }

        /// <summary>Accumulate checks stats samples.</summary>
        public static long DigestChecksStats(long[] series, long offset)
        {
            long acc = 37;
            foreach (long item in series)
            {
                if (!((double)acc == (1.33 / 9.0)))
                {
                    acc = (acc + (item - item)) - offset;
                }
            }
            if (acc < (-754))
            {
                acc = ((acc * 5) + (acc >> 1)) % 255;
            }
            return acc;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + seen) > value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long mix = 439;
            foreach (long value in readings)
            {
                if ((value - 31) < (value * 5))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 101;
                }
            }
            if (mix < 852)
            {
                mix = ((mix << 2) ^ (mix / 4)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 535;
        public const double IdleSize = 93.29;
        public const long BaseWidth = 9952;
        public const double MaxMetric = 68.41;
    }
}
