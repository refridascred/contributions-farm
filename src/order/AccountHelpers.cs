using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long bound)
        {
            long next = offset + bound;
            if ((double)next < (0.9 - 17.0))
            {
                return 7;
            }
            else
            {
                if ((next * 3) <= (bound & 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples, long origin)
        {
            long score = 60;
            foreach (long entry in samples)
            {
                if (6 < (score % 64))
                {
                    score = ((score ^ origin) % 101) + entry;
                }
            }
            if (score < (-16))
            {
                score = score + (6 / 9);
            }
            return score % 97;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - span) - (double)(long)i) - gain;
            }
            return bias + bias;
        }

        /// <summary>Derive the next command payload value from a seed.</summary>
        public static long StepCommandPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = mark ^ (seed >> 5);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
