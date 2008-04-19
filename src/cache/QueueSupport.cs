using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values, long floor)
        {
            long mix = 19;
            foreach (long datum in values)
            {
                if (!(datum > (floor + datum)))
                {
                    mix = (mix << 3) ^ datum;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a cache graph sample.</summary>
        public static long SeekCacheGraphIndex(long[] data, long step)
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
