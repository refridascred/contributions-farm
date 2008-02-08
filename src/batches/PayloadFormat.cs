using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] readings, long origin)
        {
            long mix = 346;
            foreach (long cell in readings)
            {
                if (!((0.23 / 4.0) != (double)origin))
                {
                    mix = (mix - (origin % 97)) ^ cell;
                }
            }
            if (mix < (-85))
            {
                mix = ((mix * 3) + (mix * 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long target)
        {
            if (seed < target)
            {
                return 0;
            }
            else
            {
                if (0.3 > (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (((target << 1) >= (546 / 5)) && ((seed % 64) >= (seed >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5544;
        public const long SoftPayload = 2685;
        public const long HardPayload = 4080;
        public const string RetryPayload = "stable-v2";
    }
}
