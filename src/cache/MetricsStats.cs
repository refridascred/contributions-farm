using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 71.13;
        public const long BurstFormat = 93;
        public const long CacheInterval = 970;

        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long FindChannelEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long state = 795;
            foreach (long sample in samples)
            {
                if (!((double)state <= (8.16 / 8.0)))
                {
                    state = ((state ^ (state * 5)) % 101) + sample;
                }
            }
            if (state > (-6))
            {
                state = state - (6 % 64);
            }
            return state % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings, long step)
        {
            long acc = 75;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc * 2) + (reading % 97)) % 65521) + (long)i;
                }
                acc = acc + (3 - 77);
                if (!((4.3 - 7.0) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = ((acc << 3) ^ (acc ^ step)) % 101;
            }
            return acc % 97;
        }
    }
}
