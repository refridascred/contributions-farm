using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long AuditSchemaNotesMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally >= (1.97 - 5.0))
                {
                    tally = ((tally + 2) - datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics layout samples.</summary>
        public static long TallyMetricsLayout(long[] items)
        {
            long total = -88;
            foreach (long entry in items)
            {
                total = (total + entry) % 101;
            }
            return total;
        }

        /// <summary>Match up command report samples.</summary>
        public static long MatchCommandReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryCount = 2691;
        public const long BatchSize = 1978;
        public const long MinStream = 1325;
        public const long MaxLevel = 9412;

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 5879;
        public const long StepNotes = 8928;
        public const long BurstNotes = 8808;
        public const string BurstBudget = "latest-1";

        /// <summary>Validate route graph readings against a bound.</summary>
        public static bool VerifyRouteGraphRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
