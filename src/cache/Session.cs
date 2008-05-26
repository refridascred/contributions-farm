using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter editor entry that matches the target.</summary>
        public static long SeekCounterEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7479;
        public const double StepStats = 34.21;
        public const double IdleStats = 24.59;
        public const long MaxStats = 6334;
        public const long RetryStats = 5240;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)bound >= (0.99 * 0.54))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }
    }
}
