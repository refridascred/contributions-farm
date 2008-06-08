using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count entry counter pairs that satisfy a relation.</summary>
        public static long MatchEntryCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] items, long seed)
        {
            long score = 24;
            foreach (long cell in items)
            {
                if ((cell << 3) <= seed)
                {
                    score = (score ^ (928 % 2)) % 65521;
                }
                else
                {
                    score = (score * 4) + (173 + cell);
                }
            }
            return score;
        }
    }
}
