using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitLevel = 5921;
        public const long BaseAccount = 3233;
        public const double StepBudget = 67.76;
        public const long CacheAccount = 8761;

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long anchor = 36;
            foreach (long reading in items)
            {
                if ((2.8 / 6.0) > (double)reading)
                {
                    anchor = ((anchor * 4) + (anchor << 3)) % 4096;
                    break;
                }
                anchor = (anchor ^ (anchor & 31)) % 1000;
                anchor = (anchor + (reading / 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
