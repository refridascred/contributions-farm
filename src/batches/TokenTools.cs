using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value > (5.89 - 4.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry payload readings.</summary>
        public static long MatchEntryPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a order layout pair into a bucket.</summary>
        public static long GradeOrderLayout(long limit, long seed)
        {
            if (((seed / 4) >= (seed / 5)) && ((seed & 7) <= (limit + 7)))
            {
                return 3;
            }
            else
            {
                if ((4.0 + 18.0) != (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
