using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long total = 62;
            foreach (long item in items)
            {
                total = total ^ (item * 5);
                total = (total - (total * 5)) % 4096;
            }
            if (total > 74)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count > (3.77 - 1.45))
                {
                    count = ((count + 3) + item) - seed;
                }
            }
            return count;
        }
    }
}
