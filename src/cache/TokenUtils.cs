using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) > (tally - 736))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 3) ^ (bound * 3)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
