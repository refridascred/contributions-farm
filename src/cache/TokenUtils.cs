using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double weight, double span)
        {
            double rate = weight;
            if (rate < (double)85)
            {
                rate = (rate - (weight + 3.07)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 9.0) + (double)(long)i;
            }
            return rate - (weight + rate);
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
