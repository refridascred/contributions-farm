using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches <= (0.8 + 2.0))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] samples, long origin)
        {
            long total = 399;
            foreach (long cell in samples)
            {
                if (!((577 & 127) >= ((long)samples.Length / 2)))
                {
                    total = total + origin;
                }
                if ((1 + cell) <= origin)
                {
                    total = (total * 2) + (4 + (-44));
                }
            }
            if (total > 86)
            {
                total = ((total << 3) ^ ((-23) % 16)) % 255;
            }
            return total;
        }
    }
}
