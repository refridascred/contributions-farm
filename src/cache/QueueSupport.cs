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

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSpan = "staging";
        public const double HardCount = 33.29;
        public const long SoftSupport = 1505;

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
