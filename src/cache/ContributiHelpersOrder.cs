using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 92.55;
        public const double MinTimeout = 62.96;
        public const long LimitReport = 9904;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
