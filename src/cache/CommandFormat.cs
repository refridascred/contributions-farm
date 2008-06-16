using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Scale a order token figure with a bias.</summary>
        public static double BlendOrderToken(double scale, double bias)
        {
            double load = (double)(33 << 1);
            if (load < load)
            {
                load = (load - (load - bias)) + scale;
            }
            else
            {
                load = load + (load / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 3.02) - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long state = 4;
            foreach (long value in levels)
            {
                state = (state - (state + state)) % 65521;
                if ((value < (value * 3)) || ((88 % 5) > (state + state)))
                {
                    state = (state + (value / 7)) % 65521;
                }
            }
            return state;
        }
    }
}
