using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepRatio = 464;
        public const long WindowSpan = 9249;
        public const long BaseLevel = 9355;
        public const long BurstTimeout = 5512;
        public const long SoftBuffer = 6076;

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long TallyBufferSession(long[] values, long step)
        {
            long acc = 276;
            foreach (long sample in values)
            {
                acc = (acc * 4) + sample;
            }
            if (acc < 537)
            {
                acc = (acc ^ (step & 63)) % 4096;
            }
            return acc;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
