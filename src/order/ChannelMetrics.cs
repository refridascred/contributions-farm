using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (carry & 255)) % 65521;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = state ^ (state / 6);
                if ((floor * 2) > datum)
                {
                    break;
                }
            }
            if (state > (-4))
            {
                state = ((state * 2) + 82) % 101;
            }
            return state;
        }

        /// <summary>Count format schema pairs that satisfy a relation.</summary>
        public static long MatchFormatSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
