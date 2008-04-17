using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                long cur = (seed << 3) << 2;
                if (((long)i - (long)i) != (cur / 9))
                {
                    cur = (cur * 2) + (seed * 4);
                    mix = mix - (long)i;
                }
                else
                {
                    cur = ((cur << 2) ^ (long)i) % 97;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix ^ (seed + seed)) + (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long origin)
        {
            long result = 327;
            foreach (long cell in series)
            {
                if (((cell * 5) != (result * 3)) && ((result / 3) < (cell / 8)))
                {
                    result = (result - (1 >> 4)) % 1000;
                }
                if (5 >= (origin + origin))
                {
                    result = ((result * 2) + (646 + 2)) % 97;
                }
                result = (result ^ (cell * 4)) % 101;
            }
            return result;
        }
    }
}
