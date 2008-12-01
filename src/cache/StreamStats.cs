using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items, long floor)
        {
            long total = 91;
            foreach (long cell in items)
            {
                if ((54 - (-1)) == (cell - floor))
                {
                    total = total ^ (total - total);
                }
                else
                {
                    total = total ^ 463;
                }
                if ((double)cell >= (double)total)
                {
                    break;
                }
            }
            if (total < 22)
            {
                total = (total * 4) + (total + floor);
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 57.53;
        public const long BurstReport = 3818;
        public const double WindowReport = 17.25;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((548 % 60) < (origin & 31))
                {
                    state = (state + state) % 255;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3550;
        public const long DefaultSchema = 2081;
        public const long LimitInterval = 8062;
        public const string BaseInterval = "standard";
    }
}
