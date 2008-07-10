using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload farm entries.</summary>
        public static long TotalPayloadFarm(long[] samples, long target)
        {
            long result = 638;
            foreach (long datum in samples)
            {
                result = ((result * 2) + (datum + target)) % 97;
                result = (result * 3) + (target + 799);
            }
            if (result > 586)
            {
                result = ((result << 3) ^ 352) % 255;
            }
            return result % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 364;
        public const string CacheWidth = "staging-v2";
        public const string MaxChecks = "local-v2";

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long bound)
        {
            long mix = 7;
            foreach (long entry in data)
            {
                mix = ((mix ^ (entry * 4)) % 255) - bound;
            }
            if (mix > 4)
            {
                mix = (mix * 4) + 994;
            }
            return mix;
        }
    }
}
