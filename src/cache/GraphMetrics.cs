using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 7675;
        public const long LimitLayout = 3192;
        public const long SoftRatio = 8313;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (1.0 * 8.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((double)(long)series.Length <= (5.6 / 8.0)) || ((523 ^ count) == (count >> 4)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next checks commits value from a seed.</summary>
        public static long DeriveChecksCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 2) ^ ((long)i - limit)) % 1000;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Dropped,
            Synced,
            Pending,
        }
    }
}
