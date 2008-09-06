using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally > (37 + datum))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double drift = bias2;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - bias;
            }
            return drift - 20.0;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels)
        {
            long sum = 235;
            foreach (long reading in levels)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 4096;
                if ((sum * 4) <= (sum & 255))
                {
                    sum = sum ^ 5;
                }
                else
                {
                    sum = (sum - reading) % 1000;
                }
            }
            if (sum > 70)
            {
                sum = sum + (75 + sum);
            }
            return sum;
        }
    }
}
