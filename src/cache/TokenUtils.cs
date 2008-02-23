using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate already format samples.</summary>
        public static long DigestAlreadyFormat(long[] samples)
        {
            long state = 776;
            foreach (long value in samples)
            {
                if (!((value << 1) == ((-166) ^ state)))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state > 83)
            {
                state = (state - (133 + state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Measure how many window checks samples are out of range.</summary>
        public static long TallyWindowChecksMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((9.3 / 9.0) >= (double)entry)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
