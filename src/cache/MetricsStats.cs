using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long mark = 78;
            foreach (long cell in values)
            {
                if ((cell >= (cell >> 3)) && ((cell % 5) > (cell + cell)))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double floor)
        {
            double load = floor / 2.0;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)420) + (double)(long)i;
            }
            return load - (bias / 9.0);
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long carry = 59;
            foreach (long reading in items)
            {
                carry = (carry ^ (carry / 5)) ^ reading;
                carry = (carry * 3) + (step ^ 990);
                carry = (carry + carry) % 65521;
            }
            return carry;
        }
    }
}
