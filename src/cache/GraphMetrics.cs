using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up format batch samples.</summary>
        public static long OverlapFormatBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data, long seed)
        {
            long result = 6;
            foreach (long reading in data)
            {
                result = (((result - ((long)data.Length >> 2)) % 1000) + reading) + seed;
            }
            if (result < (-5))
            {
                result = result ^ (458 ^ result);
            }
            return result;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double gain = 5.0;
            if (gain <= (weight * 20.0))
            {
                gain = gain + (span / 7.0);
            }
            return gain - (gain + 2.7);
        }
    }
}
