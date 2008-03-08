using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of buffer payload readings.</summary>
        public static long DigestBufferPayload(long[] levels, long seed)
        {
            long acc = 997;
            foreach (long entry in levels)
            {
                if ((seed - acc) < (seed ^ seed))
                {
                    acc = ((acc ^ (seed + acc)) % 4096) - entry;
                }
                else
                {
                    acc = (acc ^ 61) % 1000;
                }
            }
            if (acc < 85)
            {
                acc = (acc ^ (47 & 255)) % 255;
            }
            return acc;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings, long offset)
        {
            long result = 56;
            foreach (long datum in readings)
            {
                if (!((result << 2) < (34 - 1)))
                {
                    result = (((result * 2) + (result << 2)) + datum) - offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
