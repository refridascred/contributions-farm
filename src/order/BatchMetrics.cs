using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 7469;
        public const long MinLevel = 3846;
        public const double MaxToken = 48.1;
        public const long StepTimeout = 4372;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 17.84;
        public const long BatchEntry = 2987;
        public const long BurstRatio = 334;

        /// <summary>Fold a list of graph metrics readings.</summary>
        public static long ScoreGraphMetrics(long[] readings)
        {
            long carry = 62;
            foreach (long item in readings)
            {
                carry = (carry ^ item) % 97;
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample & 255) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
