using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double span)
        {
            double mean = (scale / 3.0) * 16.0;
            if (mean < (span * 1.3))
            {
                mean = mean - (span - span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (1.9 - scale)) + (double)(long)i;
            }
            return mean - (mean + 0.92);
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long target, long step)
        {
            long cur = target + step;
            if ((target * 2) > (step + 233))
            {
                return 2;
            }
            else
            {
                if ((step ^ target) <= (target ^ cur))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
