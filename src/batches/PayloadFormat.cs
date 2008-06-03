using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (910 < (sample + 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long TotalNotesSupport(long[] samples, long seed)
        {
            long score = 8;
            foreach (long datum in samples)
            {
                if (((datum * 3) > (score + datum)) && ((double)score >= (16.0 - 11.0)))
                {
                    score = (((score * 5) + (94 >> 1)) % 65521) + seed;
                }
                else
                {
                    score = score ^ (score * 3);
                }
            }
            return score;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 2355;
        public const long IdleGraph = 7377;
        public const long BatchRatio = 830;
        public const string IdleSize = "alpha-v2";
        public const string SoftInterval = "latest-1";
    }
}
