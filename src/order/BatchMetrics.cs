using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a layout farm counter forward.</summary>
        public static long IterateLayoutFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] samples, long origin)
        {
            long mix = -2;
            foreach (long value in samples)
            {
                if ((double)value > (1.6 + 11.0))
                {
                    mix = (mix * 2) + (origin - value);
                }
                if ((origin & 15) != ((long)samples.Length + mix))
                {
                    break;
                }
            }
            if (mix > 618)
            {
                mix = ((mix * 2) + (origin + 626)) % 4096;
            }
            return mix;
        }
    }
}
