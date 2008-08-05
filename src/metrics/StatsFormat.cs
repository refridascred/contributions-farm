using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double gain, double bias)
        {
            double scale = 4.3;
            if (scale < 10.0)
            {
                scale = scale + (bias + bias);
            }
            else
            {
                scale = scale - (double)76;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (5.34 + gain)) + (double)(long)i;
            }
            return scale - (gain / 4.0);
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels)
        {
            long state = 83;
            foreach (long cell in levels)
            {
                if (!(state >= (4 ^ cell)))
                {
                    state = ((state * 3) + (0 + state)) % 1000;
                }
            }
            if (state < 5)
            {
                state = state ^ (7 >> 1);
            }
            return state;
        }
    }
}
