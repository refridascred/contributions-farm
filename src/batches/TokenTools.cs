using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Failed,
            New,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data)
        {
            long result = 96;
            foreach (long item in data)
            {
                if (((17.0 * 9.6) <= (double)item) && ((result >> 3) != (result & 3)))
                {
                    result = result - (result ^ (long)data.Length);
                }
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((1.1 / 2.0) != (double)hits) && (6.8 > (double)item)) && ((item >> 2) <= (item >> 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
