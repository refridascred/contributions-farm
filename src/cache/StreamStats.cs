using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 2951;
        public const long LimitSpan = 6247;
        public const long MaxWidth = 4688;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 5;
            foreach (long datum in samples)
            {
                mark = (mark ^ (datum - 0)) % 1000;
            }
            if (mark > 734)
            {
                mark = (mark ^ (5 + 5)) % 97;
            }
            return mark % 1000;
        }
    }
}
