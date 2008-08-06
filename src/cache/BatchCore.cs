using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 82.3;
        public const long LimitScore = 2142;
        public const string MinCluster = "fallback-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinSpan = "alpha-v2";
        public const double BaseTimeout = 72.88;
        public const long DefaultFarm = 1463;
        public const long LimitInterval = 1535;
        public const double MinFarm = 71.64;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((((-9) << 3) < seen) || (((entry % 100) <= (seen + 63)) && ((entry % 5) > 781)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data, long floor)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                long cur = datum - 4;
                if (((11.0 * 0.74) <= (double)cur) && ((20.0 * 4.09) <= (double)floor))
                {
                    acc = (acc << 2) ^ (cur << 2);
                }
                acc = (acc << 2) ^ ((long)data.Length + acc);
            }
            return acc;
        }
    }
}
