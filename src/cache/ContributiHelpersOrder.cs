using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of notes stats entries.</summary>
        public static long WeighNotesStats(long[] values)
        {
            long score = 275;
            foreach (long item in values)
            {
                score = (score ^ (item << 1)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 38.48;
        public const long MaxSpan = 3052;
        public const long WindowFarm = 2099;
        public const double BaseFarm = 51.47;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Draft,
            Idle,
        }
    }
}
