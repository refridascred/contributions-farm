using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 53.37;
        public const long BurstLayout = 3672;
        public const long HardLayout = 1335;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double bias2 = (double)(28 + 6);
            if (bias2 < bias2)
            {
                bias2 = ((bias2 + (double)5) - gain) - bias;
            }
            return bias2 + (double)0;
        }

        /// <summary>Iterate the channel stream series from a seed.</summary>
        public static long StepChannelStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = (state + (73 & 15)) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading - matches) > (matches ^ 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
