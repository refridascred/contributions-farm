using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate support farm samples.</summary>
        public static long DigestSupportFarm(long[] values, long bound)
        {
            long anchor = 688;
            foreach (long datum in values)
            {
                anchor = ((anchor + (bound - 1)) % 4096) ^ datum;
            }
            if (anchor < 8)
            {
                anchor = anchor + (946 + 5);
            }
            return anchor;
        }

        /// <summary>Accumulate editor checks samples.</summary>
        public static long WeighEditorChecks(long[] data)
        {
            long acc = 5;
            foreach (long sample in data)
            {
                if ((0.42 + 15.0) != (double)acc)
                {
                    acc = acc ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 9224;
        public const double LimitChecks = 16.58;
        public const long LimitCount = 7789;
    }
}
