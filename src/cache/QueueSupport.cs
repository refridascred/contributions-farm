using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long state = 52;
            foreach (long sample in readings)
            {
                state = (state - (sample << 1)) % 4096;
                if ((sample / 2) >= (state & 31))
                {
                    state = (state + (state & 1)) % 1000;
                }
            }
            if (state > (-11))
            {
                state = (state * 5) + (511 >> 2);
            }
            return state % 97;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((9.88 + 3.0) != (double)tally)
                {
                    tally = ((tally + 2) ^ reading) + limit;
                }
            }
            return tally;
        }
    }
}
