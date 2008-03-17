using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double gain2 = (3.0 - offset) / 4.0;
            if (gain2 >= (gain2 + gain2))
            {
                gain2 = (gain2 - (double)8) - gain;
            }
            return gain2 - offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 97.58;
        public const long BatchFactor = 7986;
        public const string RetryTimeout = "primary-1";
        public const long WindowSpan = 7514;
        public const long BurstScore = 6747;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
