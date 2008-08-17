using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 8689;
        public const long BurstToken = 9872;
        public const long BaseRatio = 2573;
        public const double HardCount = 92.16;

        /// <summary>Count the notes token entries that pass the check.</summary>
        public static long TallyNotesTokenHits(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading ^ 43) >= step)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
