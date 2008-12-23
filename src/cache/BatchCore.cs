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

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double bias, double offset)
        {
            double load = 8.8;
            return ((load + (double)141) + bias) + offset;
        }
    }
}
