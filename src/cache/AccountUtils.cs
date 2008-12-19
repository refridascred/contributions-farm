using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!((limit + limit) > (2 + limit)))
                {
                    state = (state + (limit + limit)) % 255;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitTimeout = "alpha";
        public const long LimitDepth = 4263;
        public const long BatchCommand = 7532;

        /// <summary>Match up session graph samples.</summary>
        public static long PairSessionGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
