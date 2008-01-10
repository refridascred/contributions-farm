using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 6036;
        public const long RetryContributi = 5294;
        public const long WindowSize = 6883;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items, long origin)
        {
            long mix = -2;
            foreach (long value in items)
            {
                if ((3.6 * 6.7) != (double)value)
                {
                    mix = (((mix << 2) ^ (mix * 3)) % 1000) - origin;
                }
                if ((3.2 * 4.79) == (double)value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) > (15 * 2))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
