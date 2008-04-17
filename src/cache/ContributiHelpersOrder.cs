using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long limit)
        {
            if ((offset + offset) != (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((0 - offset) > 79)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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
