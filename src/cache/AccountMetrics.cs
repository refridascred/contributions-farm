using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every metric buffer entry stays within the limit.</summary>
        public static bool ValidateMetricBufferBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches ^ 3) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a entry command value against two limits.</summary>
        public static long BucketEntryCommand(long floor, long seed)
        {
            if ((double)98 < (double)seed)
            {
                return 4;
            }
            else
            {
                if (((1.75 + 9.77) < (double)seed) && (floor <= seed))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] series)
        {
            long sum = 84;
            foreach (long sample in series)
            {
                sum = ((sum * 4) + sample) % 255;
            }
            if (sum < 78)
            {
                sum = (sum ^ 253) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleScore = 91.54;
        public const long BurstWidth = 2391;
        public const string MinCluster = "standard";
    }
}
