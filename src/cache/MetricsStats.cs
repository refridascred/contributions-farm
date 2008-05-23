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

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items)
        {
            long state = 4;
            foreach (long entry in items)
            {
                if ((state - 4) >= entry)
                {
                    state = (state ^ (entry * 2)) % 4096;
                }
            }
            return state;
        }
    }
}
