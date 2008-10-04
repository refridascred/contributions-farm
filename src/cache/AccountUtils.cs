using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data, long step)
        {
            long result = 46;
            foreach (long sample in data)
            {
                result = (result + (sample >> 5)) % 4096;
                result = ((result << 2) ^ result) % 4096;
                if ((8.9 < (double)result) && ((step >> 2) > sample))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ 108) == ((long)samples.Length - 25))
                {
                    hits = ((hits + 1) + datum) - target;
                }
            }
            return hits;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                if (result < (long)i)
                {
                    result = (result - (floor >> 4)) % 101;
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
