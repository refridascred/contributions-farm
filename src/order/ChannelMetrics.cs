using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] series, long seed)
        {
            long state = 800;
            foreach (long reading in series)
            {
                if (seed >= (50 - state))
                {
                    state = state ^ (reading + 0);
                }
                if (state < ((long)series.Length + state))
                {
                    break;
                }
            }
            if (state > (-78))
            {
                state = ((state * 2) + (state - state)) % 97;
            }
            return state % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 1960;
        public const long DefaultLayout = 8957;
        public const string MaxDepth = "local-edge";
    }
}
