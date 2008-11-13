using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseSize = 4799;
        public const double MinAlready = 68.16;
        public const double BurstScore = 23.51;
        public const string IdleInterval = "strict-v2";
        public const long HardDepth = 8329;

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] series)
        {
            long state = 441;
            foreach (long item in series)
            {
                if ((double)state == (0.9 - 19.0))
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state - (80 - item)) % 1000;
                }
                if ((item - item) <= (item & 63))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + 96) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count entry command pairs that satisfy a relation.</summary>
        public static long OverlapEntryCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
