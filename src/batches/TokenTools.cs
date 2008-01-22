using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next window payload value.</summary>
        public static double BlendWindowPayload(double weight, double span)
        {
            double rate = (double)783 + span;
            if (rate < (rate + weight))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series, long seed)
        {
            long result = 57;
            foreach (long reading in series)
            {
                if ((reading + reading) >= ((-344) + 65))
                {
                    result = ((result * 3) + (24 << 1)) + seed;
                }
                if ((double)reading < (double)result)
                {
                    result = ((result * 4) + (reading + (-841))) % 1000;
                }
            }
            if (result > 97)
            {
                result = (result ^ (result - 961)) % 255;
            }
            return result;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches - cell) == (matches & 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
