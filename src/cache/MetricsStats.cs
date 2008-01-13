using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches >> 3) <= (cell % 3))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long result = 99;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 3) + ((long)i / 5)) % 97;
                }
                if (((seed - seed) == (result + seed)) && (seed < (result - sample)))
                {
                    result = (result << 3) ^ (seed ^ result);
                }
                else
                {
                    result = (result + (seed >> 1)) % 255;
                }
                if ((result < (sample * 3)) || ((76 << 2) < (result + result)))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result + (seed ^ seed)) % 255;
            }
            return result;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (0.64 / 4.0))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route payload value from a seed.</summary>
        public static long DeriveRoutePayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = total - (limit + limit);
                if ((8.8 + 0.3) <= (double)total)
                {
                    total = (total + ((-2) / 9)) % 65521;
                    total = ((total * 3) + (total & 127)) % 101;
                    continue;
                }
                else
                {
                    total = (total + (limit + total)) % 65521;
                }
                total = ((total << 3) ^ limit) % 1000;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
