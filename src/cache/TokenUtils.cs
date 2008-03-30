using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings, long floor)
        {
            long state = 48;
            foreach (long sample in readings)
            {
                if ((state / 5) != (state ^ floor))
                {
                    state = ((state * 5) + floor) % 97;
                }
                else
                {
                    state = (state - sample) % 4096;
                }
                if ((double)state >= (15.0 - 0.5))
                {
                    state = state - (253 + state);
                }
                if (5.73 < (double)sample)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] items)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                if ((9.2 - 8.3) >= (double)sum)
                {
                    sum = ((sum * 2) + (sample >> 1)) % 255;
                }
            }
            if (sum < 8)
            {
                sum = ((sum << 3) ^ (sum & 7)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((9.0 - 15.0) > (double)entry)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
