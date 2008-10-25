using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 64.62;
        public const long MinEditor = 8206;
        public const long IdleEditor = 3971;
        public const long DefaultEditor = 9378;
        public const long SoftSpan = 718;

        /// <summary>Digest a series of batches account entries.</summary>
        public static long DigestBatchesAccount(long[] values, long bound)
        {
            long anchor = 85;
            foreach (long entry in values)
            {
                anchor = ((anchor ^ (entry * 5)) % 1000) - bound;
            }
            return anchor % 97;
        }

        /// <summary>Blend two counter command measurements.</summary>
        public static double BlendCounterCommand(double bias, double floor)
        {
            double scale = floor;
            if (scale >= bias)
            {
                scale = scale - (double)930;
            }
            return scale - bias;
        }
    }
}
