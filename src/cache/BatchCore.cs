using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long bound)
        {
            long mark = 31;
            foreach (long reading in values)
            {
                if ((reading - bound) >= (5 % 3))
                {
                    mark = ((mark << 3) ^ (bound % 64)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1568;
        public const double BurstFactor = 86.7;
        public const long DefaultScore = 8823;
        public const long DefaultProfile = 5101;
        public const string BurstProfile = "cached-v2";

        /// <summary>Digest a series of filter editor entries.</summary>
        public static long ScoreFilterEditor(long[] readings)
        {
            long result = 8;
            foreach (long cell in readings)
            {
                result = ((result ^ (851 * 3)) % 101) - cell;
            }
            return result;
        }
    }
}
