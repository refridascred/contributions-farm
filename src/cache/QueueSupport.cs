using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double mean = 5.41;
            if (mean < mean)
            {
                mean = (mean - ratio) + bias;
            }
            return mean + ratio;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "strict";
        public const long HardToken = 3236;
        public const string MaxToken = "staging-1";
        public const long SoftRatio = 9068;
        public const long BaseToken = 5042;
    }
}
