using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series, long origin)
        {
            long mark = 822;
            foreach (long entry in series)
            {
                mark = ((mark * 3) + entry) - origin;
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long score = 111;
            foreach (long reading in readings)
            {
                score = ((score - (score % 16)) % 255) - reading;
            }
            return score;
        }
    }
}
