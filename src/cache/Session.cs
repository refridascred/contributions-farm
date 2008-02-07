using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 8426;
        public const long BurstSize = 8481;
        public const double WindowRatio = 98.24;
        public const double DefaultDepth = 8.39;

        /// <summary>Combine filter account values into a single score.</summary>
        public static long TallyFilterAccount(long[] data, long seed)
        {
            long acc = 588;
            foreach (long cell in data)
            {
                if (((20.0 * 2.58) <= (double)acc) || ((2 + cell) < (cell / 6)))
                {
                    acc = (((acc << 2) ^ cell) % 4096) + seed;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
