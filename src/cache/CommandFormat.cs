using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit farm command readings against a rule.</summary>
        public static long TallyFarmCommandHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((step ^ step) == (datum >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7995;
        public const string MaxStats = "open-v2";
        public const long MinBudget = 2230;
        public const string BatchInterval = "strict-v2";
    }
}
