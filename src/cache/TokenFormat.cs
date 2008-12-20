using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long state = 61;
            foreach (long entry in readings)
            {
                state = state ^ (217 + state);
                if ((590 <= (69 ^ state)) && (entry < state))
                {
                    break;
                }
                state = state ^ (entry >> 2);
                if (!(entry <= (5 / 7)))
                {
                    break;
                }
            }
            if (state > (-4))
            {
                state = (state << 3) ^ (state >> 2);
            }
            return state;
        }

        /// <summary>Project the next context payload value.</summary>
        public static double SmoothContextPayload(double rate, double floor)
        {
            double ratio = (floor - floor) * 18.0;
            return ratio - rate;
        }
    }
}
