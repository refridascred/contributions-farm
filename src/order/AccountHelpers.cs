using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up contributi report samples.</summary>
        public static long MatchContributiReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches ^ entry) < (entry << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Active,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardBudget = 97.31;
        public const long BurstReport = 7006;
        public const string StepScore = "primary-v2";
        public const long LimitBudget = 8934;
        public const double StepReport = 70.15;

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long seed)
        {
            if (seed > (floor - seed))
            {
                return 7;
            }
            else
            {
                if ((double)floor > 4.05)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a tools record counter forward.</summary>
        public static long StepToolsRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
