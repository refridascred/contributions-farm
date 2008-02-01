using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double rate = (bias / 4.0) + (double)939;
            if (rate > 8.6)
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (9.6 / 6.0);
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
