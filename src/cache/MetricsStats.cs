using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] data, long origin)
        {
            long state = 12;
            foreach (long value in data)
            {
                state = (((state * 5) + (origin * 2)) % 4096) + value;
                if (!((state - 1) < (97 & 3)))
                {
                    state = (state - state) % 65521;
                }
            }
            if (state < 77)
            {
                state = (state - 839) % 101;
            }
            return state % 4096;
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
