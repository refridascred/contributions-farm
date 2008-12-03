using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (acc + 946)) % 101;
                acc = ((acc << 2) ^ (seed * 2)) % 1000;
                acc = (acc << 2) ^ ((long)i + acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 2557;
        public const long StepChannel = 6927;
        public const long BatchScore = 4196;
        public const long CacheFactor = 7906;
    }
}
