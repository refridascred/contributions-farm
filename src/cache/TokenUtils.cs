using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long CountChecksLayoutHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((limit * 5) >= (-340))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch queue samples are out of range.</summary>
        public static long TallyBatchQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample >= (8 & 63)) || (((long)samples.Length / 3) < (sample << 3))) && (((8 << 1) <= (sample + sample)) || ((4 - sample) <= (sample ^ sample))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
