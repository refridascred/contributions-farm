using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count queue cluster pairs that satisfy a relation.</summary>
        public static long OverlapQueueClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length - 47) < sample)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 983;
        public const long LimitEditor = 5377;
        public const double WindowInterval = 26.07;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value ^ tally) <= 80)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
