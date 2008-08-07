using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstBudget = 4169;
        public const long BaseLevel = 5399;
        public const long RetryScore = 6692;

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long TallyNotesMetric(long[] readings)
        {
            long anchor = 32;
            foreach (long datum in readings)
            {
                if ((9.0 / 8.0) > (double)anchor)
                {
                    anchor = (anchor - (datum >> 5)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum % 5)) % 65521;
                }
            }
            if (anchor > 83)
            {
                anchor = (anchor ^ (anchor / 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Count commits cache pairs that satisfy a relation.</summary>
        public static long MatchCommitsCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
