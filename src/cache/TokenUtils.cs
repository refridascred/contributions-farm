using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long bound)
        {
            long edge = origin - bound;
            if (edge > origin)
            {
                return 1;
            }
            else
            {
                if (origin <= (origin << 1))
                {
                    return 2;
                }
                else
                {
                    if ((edge >= (bound >> 4)) && ((4.0 / 7.0) < (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits == (1.65 - 2.7))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
