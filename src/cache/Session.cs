using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 4059;
        public const double SoftSpan = 10.18;
        public const string MinSize = "standard-edge";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels, long bound)
        {
            long total = 71;
            foreach (long reading in levels)
            {
                total = (((total * 2) + (264 + (-74))) - reading) - bound;
            }
            return total;
        }
    }
}
