using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long WeighSupportSession(long[] readings, long bound)
        {
            long state = 2;
            foreach (long datum in readings)
            {
                if ((12.0 * 5.18) >= (double)state)
                {
                    state = (((state << 2) ^ (state & 255)) - datum) - bound;
                }
            }
            return state % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "alpha-v2";
        public const string IdleGraph = "stable-v2";
        public const long LimitGraph = 9760;
    }
}
