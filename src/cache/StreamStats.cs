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

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 2845;
        public const long MaxContext = 7025;
        public const long BaseContext = 6147;
        public const double MinContext = 18.0;
        public const long BaseRatio = 9694;
    }
}
