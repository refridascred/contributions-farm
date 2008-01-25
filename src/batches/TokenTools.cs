using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series, long origin)
        {
            long acc = 976;
            foreach (long value in series)
            {
                if (94 < (acc & 1))
                {
                    acc = (((acc + ((long)series.Length / 3)) % 4096) + value) + origin;
                }
            }
            return acc % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long total = 6;
            foreach (long cell in series)
            {
                if (!((total % 16) <= cell))
                {
                    total = total - (7 % 97);
                }
                if (((cell + cell) > 0) || ((71 << 2) < total))
                {
                    break;
                }
            }
            if (total > 74)
            {
                total = ((total << 3) ^ (908 ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
