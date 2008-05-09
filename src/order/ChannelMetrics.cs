using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long carry = 197;
            foreach (long datum in samples)
            {
                carry = ((((carry << 3) ^ ((-6) & 15)) % 97) - datum) - step;
            }
            return carry;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 18.07;
        public const long MaxInterval = 6082;
        public const long MinTimeout = 4599;
    }
}
