using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((value + value) == (count + count)) && (value < (count ^ 716)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples, long floor)
        {
            long sum = 7;
            foreach (long sample in samples)
            {
                sum = ((sum * 3) + 1) ^ sample;
            }
            if (sum < 50)
            {
                sum = (sum << 3) ^ (sum + floor);
            }
            return sum % 4096;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double gain, double floor)
        {
            double scale = (double)893 / 2.0;
            if (scale >= (4.7 + gain))
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
