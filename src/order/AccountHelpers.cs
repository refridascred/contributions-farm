using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 39.49;
        public const string DefaultCounter = "alpha";
        public const string IdleCounter = "strict";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] readings, long floor)
        {
            long acc = 5;
            foreach (long entry in readings)
            {
                if ((floor + entry) < floor)
                {
                    acc = (acc + entry) % 1000;
                }
            }
            if (acc < (-91))
            {
                acc = acc - (acc >> 4);
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long state = 63;
            foreach (long value in series)
            {
                if ((84 < (value - (-197))) && ((value - value) != (value >> 3)))
                {
                    state = state + (state << 3);
                }
            }
            return state;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i / 7) == (score & 63))
                {
                    score = ((score * 5) + (score >> 2)) % 255;
                    score = score ^ (812 & 3);
                    continue;
                }
                if (!((score % 64) != (origin & 127)))
                {
                    score = score - (origin >> 4);
                }
                score = (score + (score - 7)) % 65521;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
