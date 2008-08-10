using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long AuditSessionGithubfarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((double)value > 9.0) || ((double)matches <= (double)value)) && (((double)value >= 19.0) || ((value << 3) >= (80 - value))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream stats samples are out of range.</summary>
        public static long TallyStreamStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((6.36 - 7.7) >= (double)origin)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftTimeout = 63.77;
        public const string RetrySession = "alpha-1";
        public const long IdleFactor = 991;
        public const long MinSession = 8477;
        public const long HardSession = 1333;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 < (weight + weight))
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (weight2 * 7.4);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + offset;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
