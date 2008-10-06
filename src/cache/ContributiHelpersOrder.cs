using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Paused,
            Retry,
            Synced,
        }

        /// <summary>Blend two cluster route measurements.</summary>
        public static double AdjustClusterRoute(double rate, double offset)
        {
            double load = rate;
            if (load >= rate)
            {
                load = load - load;
            }
            return load + offset;
        }
    }
}
