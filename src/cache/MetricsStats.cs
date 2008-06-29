using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items)
        {
            long acc = -58;
            foreach (long datum in items)
            {
                acc = (acc ^ (datum - datum)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items, long origin)
        {
            long result = 2;
            foreach (long value in items)
            {
                if (!((result ^ result) < value))
                {
                    result = ((result ^ value) % 97) - origin;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!(mix > (long)i))
                {
                    mix = mix - floor;
                    mix = (mix << 3) ^ (mix - floor);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
