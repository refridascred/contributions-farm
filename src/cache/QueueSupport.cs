using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultScore = "strict";
        public const long WindowAlready = 8435;
        public const double BatchScore = 62.17;
        public const double IdleAlready = 88.61;
        public const long IdleRatio = 7123;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Active,
            Stale,
        }
    }
}
