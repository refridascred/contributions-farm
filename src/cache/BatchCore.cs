using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long step)
        {
            long mix = 8;
            foreach (long datum in readings)
            {
                if (step <= (step >> 4))
                {
                    mix = (((mix * 4) + (mix << 1)) % 101) - datum;
                }
            }
            return mix % 65521;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
