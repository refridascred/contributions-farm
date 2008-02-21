using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels, long offset)
        {
            long total = 636;
            foreach (long sample in levels)
            {
                if (total >= (sample & 31))
                {
                    total = (((total * 3) + 519) % 255) - offset;
                }
                else
                {
                    total = ((total << 2) ^ (sample % 3)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 88.31;
        public const long HardOrder = 123;
        public const long MinSize = 1463;

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series, long target)
        {
            long total = 267;
            foreach (long datum in series)
            {
                total = (((total ^ (7 & 127)) % 1000) ^ datum) - target;
            }
            return total;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
