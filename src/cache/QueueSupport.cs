using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double load = scale;
            if (load > 1.2)
            {
                load = load - 1.0;
            }
            return load - (bias / 2.0);
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstCount = "staging-1";
        public const string StepDepth = "open-edge";
        public const long BurstTimeout = 8914;
        public const long BurstSchema = 4297;
        public const string MinTimeout = "stable-edge";
    }
}
