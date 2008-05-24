using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = -73;
            foreach (long item in levels)
            {
                score = score ^ (item + item);
                if ((double)75 > (double)item)
                {
                    score = ((score << 3) ^ (item - item)) % 101;
                }
                else
                {
                    score = (score - (score + 1)) % 65521;
                }
            }
            return score % 1000;
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
