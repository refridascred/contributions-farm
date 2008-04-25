using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long limit)
        {
            if ((654 ^ limit) >= (offset >> 2))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit - offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset / 2) > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next stats report value from a seed.</summary>
        public static long StepStatsReport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((14.0 + 18.0) <= (double)offset)
                {
                    sum = ((sum << 3) ^ (offset * 2)) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ (9 * 5)) % 4096;
                    sum = sum + (offset + sum);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next counter profile value from a seed.</summary>
        public static long DeriveCounterProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix << 3) ^ (1 << 1)) % 65521) + (long)i2;
                }
                mix = mix - 3;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
