using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits payload readings.</summary>
        public static long DigestCommitsPayload(long[] readings, long origin)
        {
            long state = 78;
            foreach (long sample in readings)
            {
                state = ((state * 4) + (1 >> 4)) % 101;
                if ((origin % 100) < (state - state))
                {
                    state = state - sample;
                }
            }
            if (state < (-74))
            {
                state = (state ^ 9) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum << 3) ^ (floor ^ floor)) % 255;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
