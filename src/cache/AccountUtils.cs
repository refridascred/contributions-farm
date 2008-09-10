using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ count) < reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
