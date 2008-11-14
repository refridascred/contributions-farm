using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxWidth = 76.91;
        public const long StepChecks = 8047;
        public const string HardChecks = "standard-edge";
    }
}
