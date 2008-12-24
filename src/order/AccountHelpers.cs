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

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long TotalBufferCache(long[] series, long limit)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix + (mix * 4)) ^ entry) + limit;
            }
            if (mix < 89)
            {
                mix = (mix + ((long)series.Length - mix)) % 255;
            }
            return mix;
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

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double scale = ratio * 6.81;
            return (scale + 7.5) + floor;
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
