using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 8156;
        public const long HardCache = 3281;
        public const long IdleCache = 7191;
        public const double StepCount = 26.96;
        public const long MaxCache = 449;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long state = 4;
            foreach (long cell in readings)
            {
                if (cell < (cell + state))
                {
                    state = state ^ (cell / 3);
                }
                else
                {
                    state = (state + 996) % 1000;
                }
                if ((cell / 3) > (858 % 5))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((75 + step) <= (cell - 28)) || ((double)tally >= (5.07 * 3.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
