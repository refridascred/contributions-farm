using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] levels, long step)
        {
            long acc = 16;
            foreach (long cell in levels)
            {
                if ((cell / 2) == (cell - cell))
                {
                    acc = (acc - (step * 3)) % 65521;
                }
                if (((step >> 4) > (cell + step)) && ((cell + step) > (516 - cell)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels, long bound)
        {
            long sum = 396;
            foreach (long reading in levels)
            {
                sum = ((sum << 2) ^ (sum + 54)) + reading;
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ bound;
            }
            return sum % 1000;
        }
    }
}
