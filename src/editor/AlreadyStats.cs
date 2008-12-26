using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 7791;
        public const long LimitCache = 5729;
        public const long StepCache = 516;
        public const long BaseCache = 5466;
        public const string WindowCache = "local-1";

        /// <summary>Iterate the buffer graph series from a seed.</summary>
        public static long StepBufferGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((total + total) > (bound ^ (long)i)) && (bound > 22))
                {
                    total = ((total * 4) + (long)i) % 65521;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ total) % 255;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
