using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double load = 5.6;
            if (load > (double)67)
            {
                load = (load + (load - scale)) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
