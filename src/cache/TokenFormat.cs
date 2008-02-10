using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double load = bias;
            if (load >= (double)4)
            {
                load = (load + load) + span;
            }
            else
            {
                load = load - 7.5;
            }
            return load + 3.67;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate counter stats samples.</summary>
        public static long CombineCounterStats(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((mix + mix) != ((-211) / 3))
                {
                    mix = ((mix - (mix + 283)) % 1000) - datum;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (mix * 5)) % 97;
            }
            return mix % 1000;
        }
    }
}
