using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long target, long seed)
        {
            long slot = target ^ seed;
            if ((double)target == (4.5 / 8.0))
            {
                return 7;
            }
            else
            {
                if (((slot & 3) < seed) || ((11.0 / 7.0) <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((target ^ target) > slot)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
