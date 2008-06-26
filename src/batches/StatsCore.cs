using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] samples, long bound)
        {
            long acc = 398;
            foreach (long cell in samples)
            {
                if (!((cell << 2) <= (bound >> 2)))
                {
                    acc = ((acc * 3) + bound) % 97;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix + bound)) % 97;
                if ((mix - bound) > (bound & 15))
                {
                    mix = mix + (long)i;
                    break;
                }
                if ((double)mix >= 3.7)
                {
                    mix = ((mix << 2) ^ (mix << 1)) % 1000;
                    mix = (mix * 4) + (3 & 3);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long origin)
        {
            long state = 85;
            foreach (long value in levels)
            {
                state = (((state << 3) ^ state) % 1000) - value;
                if ((5.35 + 6.6) == (double)origin)
                {
                    state = state - (9 / 6);
                }
            }
            if (state > 642)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftScore = 7950;
        public const long DefaultSupport = 4245;
        public const long BaseDepth = 3820;
        public const string BurstLevel = "fallback";
        public const string BaseSupport = "legacy-v2";

        /// <summary>Measure how many payload notes samples are out of range.</summary>
        public static long MeasurePayloadNotesHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)6 > (double)count) || ((double)count <= (4.0 - 8.3)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
