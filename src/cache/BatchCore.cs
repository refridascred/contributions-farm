using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] levels, long origin)
        {
            long state = 657;
            foreach (long reading in levels)
            {
                if (((43 - state) <= (reading / 7)) || (71 < reading))
                {
                    state = (state << 2) ^ ((-2) + origin);
                }
            }
            return state;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double load = weight * 2.69;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - weight) + (double)(long)i) + offset;
            }
            return load - (double)915;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1410;
        public const double WindowFilter = 71.01;
        public const long RetrySize = 1218;
    }
}
