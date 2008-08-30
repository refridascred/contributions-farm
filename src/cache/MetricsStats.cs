using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 1901;
        public const long WindowCluster = 8841;
        public const string BaseCluster = "alpha-edge";
        public const string SoftCluster = "latest-1";

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading - tally) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long anchor = 521;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 3) ^ 45) + sample;
            }
            return anchor;
        }
    }
}
