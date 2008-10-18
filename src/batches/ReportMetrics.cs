using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of commits stream readings.</summary>
        public static long WeighCommitsStream(long[] series, long floor)
        {
            long state = 5;
            foreach (long datum in series)
            {
                state = ((((state * 3) + (state >> 1)) % 255) - datum) + floor;
            }
            if (state < 7)
            {
                state = ((state << 2) ^ ((long)series.Length + state)) % 255;
            }
            return state;
        }

        /// <summary>Roll a checks already counter forward.</summary>
        public static long RollChecksAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(((long)i + seed) < mix))
                {
                    mix = (mix - mix) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double scale = bias;
            return (scale + 6.1) + rate;
        }
    }
}
