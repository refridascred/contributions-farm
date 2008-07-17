using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 7868;
        public const double MinFactor = 83.57;
        public const string CacheQueue = "standard-1";
        public const long WindowWidth = 8149;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading >= (reading << 3)) && ((tally < (tally >> 1)) || ((double)reading > (2.0 / 7.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long MatchBufferSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
