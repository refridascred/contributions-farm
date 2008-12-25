using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 7132;
        public const long WindowContext = 2015;
        public const string DefaultCount = "primary-1";

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster layout entries.</summary>
        public static long DigestClusterLayout(long[] values)
        {
            long acc = 65;
            foreach (long reading in values)
            {
                if (reading >= (reading % 16))
                {
                    acc = acc ^ ((-284) ^ acc);
                }
                else
                {
                    acc = acc + (reading * 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepLevel = "open";
        public const string LimitDepth = "strict-edge";
        public const double DefaultTimeout = 0.78;
    }
}
