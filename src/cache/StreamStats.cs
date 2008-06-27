using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell << 2) != (step >> 2)) || ((seen * 5) >= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double scale, double offset)
        {
            double load = scale;
            if (load < (double)9)
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (3.9 / 4.0)) - (double)(long)i;
            }
            return load - (offset - scale);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxInterval = "fallback-edge";
        public const double LimitLayout = 77.4;
        public const long BaseLayout = 571;

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double load = (double)3;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - (double)(long)i) + gain) + offset;
            }
            return load - 2.5;
        }
    }
}
