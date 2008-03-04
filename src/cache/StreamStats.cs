using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 1838;
        public const string SoftRoute = "fallback-1";
        public const long IdleSpan = 9261;
        public const long BurstRoute = 7668;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Closed,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] values)
        {
            long mark = 3;
            foreach (long datum in values)
            {
                mark = (mark + ((-19) - mark)) % 255;
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark ^ 681) ^ (long)i;
                }
                if (!(5.3 > (double)datum))
                {
                    mark = ((mark * 2) + (mark % 24)) % 65521;
                }
            }
            if (mark < 31)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
