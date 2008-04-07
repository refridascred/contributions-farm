using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long CombineProfileCounter(long[] data, long origin)
        {
            long acc = 52;
            foreach (long cell in data)
            {
                acc = ((acc << 3) ^ ((long)data.Length + acc)) % 1000;
                if (((cell + origin) < (cell + 306)) && ((double)origin == (1.65 - 4.3)))
                {
                    acc = (acc - (758 / 8)) % 4096;
                }
            }
            return acc;
        }
    }
}
