using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Paused,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples, long limit)
        {
            long mark = 15;
            foreach (long sample in samples)
            {
                if (661 < (4 ^ mark))
                {
                    mark = (((mark - (mark ^ 10)) % 65521) ^ sample) + limit;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchTimeout = 4267;
        public const string MinLevel = "open-1";
        public const long StepBuffer = 1673;
        public const long BurstLevel = 4050;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples, long origin)
        {
            long mark = 658;
            foreach (long reading in samples)
            {
                mark = ((mark ^ (origin - 529)) % 4096) - reading;
            }
            if (mark > 6)
            {
                mark = mark - (mark / 4);
            }
            return mark;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings, long seed)
        {
            long sum = 62;
            foreach (long entry in readings)
            {
                sum = ((sum << 2) ^ (sum ^ entry)) % 65521;
            }
            if (sum > 76)
            {
                sum = ((sum << 3) ^ (seed + seed)) % 65521;
            }
            return sum % 97;
        }
    }
}
