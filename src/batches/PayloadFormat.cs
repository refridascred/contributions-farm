using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstBudget = 9809;
        public const long RetryCount = 989;
        public const long MinCluster = 5081;
        public const long DefaultBudget = 1051;

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 24) <= (tally * 3))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
