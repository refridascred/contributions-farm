using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of graph support entries.</summary>
        public static long CombineGraphSupport(long[] samples, long bound)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if (((carry + bound) != (carry - carry)) && ((carry + bound) > (2 % 100)))
                {
                    carry = (((carry * 2) + 7) % 101) - value;
                }
                else
                {
                    carry = (carry ^ (-161)) % 255;
                }
            }
            if (carry > 48)
            {
                carry = (carry - (bound << 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Iterate the metric cache series from a seed.</summary>
        public static long SeriesMetricCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
