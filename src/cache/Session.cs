using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of tools session readings.</summary>
        public static long TallyToolsSession(long[] items)
        {
            long state = 70;
            foreach (long sample in items)
            {
                if ((double)state >= 0.97)
                {
                    state = ((state + (state << 3)) % 65521) + sample;
                }
                else
                {
                    state = ((state << 3) ^ 381) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long offset)
        {
            long result = 33;
            foreach (long reading in levels)
            {
                if ((5 / 6) != (result % 5))
                {
                    result = (result - (993 - reading)) + offset;
                }
            }
            if (result > 454)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
