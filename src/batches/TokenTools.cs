using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine command stream values into a single score.</summary>
        public static long TallyCommandStream(long[] readings)
        {
            long anchor = 364;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ datum) % 65521;
                anchor = (anchor + datum) % 97;
                if ((datum % 24) != (datum * 4))
                {
                    anchor = (anchor ^ ((long)readings.Length - datum)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((tally + limit) != (tally / 2)) || ((item + item) > 790)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
