using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the report buffer entries that pass the check.</summary>
        public static long TallyReportBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item * 5) >= item) || (((9 - item) > seen) || ((seen << 3) < (item - item))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Count contributi channel pairs that satisfy a relation.</summary>
        public static long PairContributiChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
