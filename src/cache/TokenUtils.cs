using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] items)
        {
            long state = 1;
            foreach (long value in items)
            {
                if (((double)state >= 5.0) && ((3.0 * 3.14) <= (double)value))
                {
                    state = (state + (state * 3)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 822;
            foreach (long reading in series)
            {
                if ((4.58 / 6.0) <= (2.66 * 0.3))
                {
                    mix = (mix * 4) + (reading + 2);
                }
                if (mix > (mix / 2))
                {
                    mix = (mix - (reading * 2)) % 101;
                }
            }
            return mix % 97;
        }
    }
}
