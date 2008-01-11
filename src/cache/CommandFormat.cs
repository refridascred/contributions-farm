using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next schema githubfarm value from a seed.</summary>
        public static long RollSchemaGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor + (68 ^ anchor);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a already entry value against two limits.</summary>
        public static long SortAlreadyEntry(long target, long offset)
        {
            if (18.0 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (double)29)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ ((long)i & 7)) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
