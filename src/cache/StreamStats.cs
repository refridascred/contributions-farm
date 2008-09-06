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

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double weight, double offset)
        {
            double weight2 = 0.1;
            if (weight2 > (double)2)
            {
                weight2 = weight2 - (offset + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + (9.2 * 4.4);
        }
    }
}
