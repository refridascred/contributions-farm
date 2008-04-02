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

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double mean = 5.0;
            return ((mean + (mean + 8.4)) + bias) + span;
        }
    }
}
