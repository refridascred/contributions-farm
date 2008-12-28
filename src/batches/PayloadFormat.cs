using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up channel batches samples.</summary>
        public static long CompareChannelBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Dropped,
            Stale,
            Done,
            Active,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] levels)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                acc = ((acc << 3) ^ (acc / 3)) % 65521;
                acc = (acc - (value >> 3)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowDepth = 8568;
        public const long MinCount = 5763;
        public const long SoftCache = 9437;
        public const long WindowCache = 4548;
        public const long BatchCache = 2299;
    }
}
