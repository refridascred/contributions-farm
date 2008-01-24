using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double drift = (double)96 / 6.0;
            if (drift > ratio)
            {
                drift = drift + (double)4;
            }
            else
            {
                drift = drift - (floor + ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Find the first token githubfarm entry that matches the target.</summary>
        public static long LookupTokenGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
