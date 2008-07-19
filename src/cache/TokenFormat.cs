using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstTimeout = 6625;
        public const long BaseInterval = 1647;
        public const string IdleChecks = "primary-v2";

        /// <summary>Locate a filter report reading by value.</summary>
        public static long SeekFilterReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record tools figure with a bias.</summary>
        public static double BlendRecordTools(double gain, double offset)
        {
            double drift = (double)(-74);
            if (drift <= (gain / 9.0))
            {
                drift = (drift + (drift + drift)) + offset;
            }
            else
            {
                drift = drift - 15.0;
            }
            return drift - (drift + gain);
        }
    }
}
