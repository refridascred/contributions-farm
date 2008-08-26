using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data, long target)
        {
            long acc = 344;
            foreach (long entry in data)
            {
                if (!((entry + acc) < acc))
                {
                    acc = ((acc << 3) ^ (acc ^ 890)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (acc >> 4)) % 255;
                }
                if (((0.53 - 15.0) < (double)target) && ((acc ^ target) == (acc + target)))
                {
                    acc = (acc << 3) ^ (entry + target);
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
