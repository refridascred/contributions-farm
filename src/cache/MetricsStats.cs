using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings)
        {
            long mix = 828;
            foreach (long cell in readings)
            {
                mix = mix + (mix << 2);
                if (((cell * 4) <= (mix - cell)) || ((mix + (long)readings.Length) != (cell >> 2)))
                {
                    mix = (mix ^ 2) % 4096;
                }
            }
            if (mix < 0)
            {
                mix = mix ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long bound)
        {
            long anchor = 400;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 5) + (-214)) + datum) + bound;
            }
            if (anchor > 995)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
