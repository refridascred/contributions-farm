using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((floor <= (tally % 60)) && ((floor > tally) && (5.94 > (double)tally)))
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of farm account readings.</summary>
        public static long MatchFarmAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstInterval = 27.24;
        public const double SoftRoute = 15.3;
        public const long WindowSize = 8815;
        public const long BurstLevel = 6402;
        public const long StepRoute = 2168;
    }
}
