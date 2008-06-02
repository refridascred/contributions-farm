using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 4328;
        public const double HardBatches = 25.94;
        public const long MaxScore = 8829;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardFactor = 7028;
        public const long StepRatio = 8418;
        public const double MaxBudget = 54.3;

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine schema report values into a single score.</summary>
        public static long TotalSchemaReport(long[] levels)
        {
            long mark = 475;
            foreach (long sample in levels)
            {
                mark = ((mark * 5) + (sample - 882)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally << 3) <= (value >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
