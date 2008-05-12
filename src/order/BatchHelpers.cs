using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count <= (6.0 - 11.0))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count channel record pairs that satisfy a relation.</summary>
        public static long MatchChannelRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long target, long limit)
        {
            if ((target / 7) <= limit)
            {
                return 6;
            }
            else
            {
                if ((9.0 * 9.99) >= (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
