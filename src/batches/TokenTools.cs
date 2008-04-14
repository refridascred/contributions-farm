using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Count profile buffer pairs that satisfy a relation.</summary>
        public static long OverlapProfileBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double mean = (offset - gain) / 4.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean - offset)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
