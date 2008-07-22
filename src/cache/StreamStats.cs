using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepInterval = 92;
        public const long MinBatches = 1986;
        public const long BurstBatches = 3078;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long floor)
        {
            long mix = -98;
            foreach (long entry in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix ^ (317 << 1)) % 97) ^ (long)i;
                }
                if (entry >= (mix * 2))
                {
                    mix = (mix + (323 + floor)) % 1000;
                }
                else
                {
                    mix = ((mix * 3) + (5 << 2)) % 97;
                }
                if ((mix + entry) <= (-8))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((double)reading >= (6.5 + 3.12)) && ((double)reading <= 17.0))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
