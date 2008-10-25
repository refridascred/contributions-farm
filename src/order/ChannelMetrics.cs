using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (sum + sum)) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                if (((3.0 - 6.0) != (double)result) && (result < (result + 95)))
                {
                    result = (((result * 2) + result) % 1000) ^ cell;
                }
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((entry + seen) == (seen - seen)) && ((8.0 / 9.0) >= (double)entry)) || ((entry + seen) <= (seen % 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
