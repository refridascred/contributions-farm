using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next entry order value.</summary>
        public static double SmoothEntryOrder(double weight, double floor)
        {
            double mean = weight;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (floor / 3.0)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
