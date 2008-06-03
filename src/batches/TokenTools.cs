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

        /// <summary>Roll a payload filter counter forward.</summary>
        public static long StepPayloadFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
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
