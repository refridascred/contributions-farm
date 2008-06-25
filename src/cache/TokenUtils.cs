using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next stream contributi value from a seed.</summary>
        public static long SeriesStreamContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit + limit) > ((long)i & 63))
                {
                    state = (state - (10 << 1)) % 101;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value - matches) >= (step - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter report value.</summary>
        public static double ScaleCounterReport(double gain, double span)
        {
            double mean = span;
            return (mean - span) + gain;
        }
    }
}
