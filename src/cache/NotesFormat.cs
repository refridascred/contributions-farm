using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 1285;
        public const double RetryFormat = 41.51;
        public const string StepInterval = "alpha-1";
        public const string BatchDepth = "stable-1";

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double weight, double bias)
        {
            double gain = weight;
            if (gain > (double)64)
            {
                gain = gain - (bias - gain);
            }
            return gain - (gain * 0.15);
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
