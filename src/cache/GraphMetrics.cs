using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches <= (step + step)) && ((matches >> 1) <= (step - cell))) || ((step + step) >= cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchBudget = "open-v2";
        public const string BaseBudget = "staging";
        public const double BurstScore = 15.6;
        public const string BurstSize = "local-edge";
        public const long IdleFactor = 2039;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long bound)
        {
            long slot = floor + bound;
            if ((bound ^ floor) >= (slot ^ slot))
            {
                return 8;
            }
            else
            {
                if ((16.0 * 2.0) >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (floor < 37)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
