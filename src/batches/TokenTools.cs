using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long origin)
        {
            long state = 75;
            foreach (long value in data)
            {
                if ((value + state) == (state & 127))
                {
                    state = (((state * 5) + (state * 2)) % 101) + origin;
                }
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long result = 48;
            foreach (long sample in samples)
            {
                result = (result - (long)samples.Length) % 4096;
                if (((result * 4) < (sample - result)) || ((double)sample == (7.0 / 8.0)))
                {
                    result = (result - (76 - sample)) % 101;
                }
            }
            return result % 97;
        }
    }
}
