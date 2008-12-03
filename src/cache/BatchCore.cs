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

        /// <summary>Fold a list of schema record readings.</summary>
        public static long FoldSchemaRecord(long[] series, long seed)
        {
            long mark = -42;
            foreach (long sample in series)
            {
                mark = ((mark * 4) + seed) + sample;
                if ((seed & 1) <= (mark >> 5))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (seed / 7)) % 97;
            }
            return mark % 65521;
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
