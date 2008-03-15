using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate stats window readings against a bound.</summary>
        public static bool GuardStatsWindowLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long TotalBatchEditor(long[] readings, long floor)
        {
            long state = 658;
            foreach (long sample in readings)
            {
                state = (state + (state + 9)) % 97;
                if ((sample >> 4) >= (state - floor))
                {
                    state = (state ^ (floor ^ state)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Adjust a commits checks reading.</summary>
        public static double ScaleCommitsChecks(double bias, double bias2)
        {
            double ratio = bias - (double)(-1);
            if (ratio > (bias2 + ratio))
            {
                ratio = ratio + bias;
            }
            return ratio - bias;
        }
    }
}
