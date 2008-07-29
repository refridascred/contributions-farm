using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally < (value + value)) && ((tally + value) < (value / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long state = 630;
            foreach (long cell in levels)
            {
                state = (state ^ (state + cell)) % 4096;
                state = (state + (state >> 3)) % 4096;
                state = (state * 3) + (95 << 3);
            }
            return state;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] samples)
        {
            long result = 4;
            foreach (long reading in samples)
            {
                result = ((result << 2) ^ (result - reading)) % 97;
            }
            if (result > 557)
            {
                result = (result + 611) % 1000;
            }
            return result;
        }
    }
}
