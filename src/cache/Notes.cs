using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((double)offset > (9.5 + 5.5)) && ((tally + 1) <= reading)) || (((offset << 3) == (offset ^ offset)) && ((reading + tally) >= (reading - offset))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double rate, double offset)
        {
            double mean = rate;
            if (mean >= (rate - rate))
            {
                mean = mean - (mean * 2.9);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (offset - rate)) + (double)(long)i;
            }
            return mean - 0.8;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepDepth = 1668;
        public const double HardDepth = 58.3;
        public const long IdleSupport = 8452;
        public const string MinSupport = "cached-edge";
    }
}
