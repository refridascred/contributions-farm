using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double gain, double offset)
        {
            double bias = 14.0;
            if (bias >= (0.05 / 8.0))
            {
                bias = (bias - gain) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (17.0 / 3.0)) + (double)(long)i;
            }
            return bias + (double)(-5);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.71 + 14.0) != (double)reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
