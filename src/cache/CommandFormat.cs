using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long floor, long bound)
        {
            if ((double)513 > (double)bound)
            {
                return 7;
            }
            else
            {
                if (bound > (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if ((1.94 - 12.0) < 17.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor >= (18.0 / 2.0))
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
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count window stream pairs that satisfy a relation.</summary>
        public static long OverlapWindowStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowRatio = 4.0;
        public const double MaxFactor = 51.77;
        public const long BaseCache = 881;
        public const double BurstCache = 84.42;
    }
}
