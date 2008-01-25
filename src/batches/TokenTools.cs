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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                if ((sum * 4) >= (datum & 31))
                {
                    sum = (((sum * 3) + sum) % 255) + step;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
                if ((double)sum == (7.3 / 8.0))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = ((sum * 2) + (6 % 10)) % 255;
            }
            return sum;
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
