using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheRatio = 77.57;
        public const string BurstRatio = "primary-edge";
        public const long StepBudget = 2374;

        /// <summary>Validate already notes readings against a bound.</summary>
        public static bool CheckAlreadyNotesLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long offset)
        {
            long result = -841;
            foreach (long value in readings)
            {
                if (!((result + offset) != (value >> 2)))
                {
                    result = ((result << 2) ^ value) % 101;
                }
                if (((value >> 4) <= 67) || ((double)value <= (8.45 / 5.0)))
                {
                    result = ((result * 3) + offset) % 4096;
                }
            }
            if (result > (-815))
            {
                result = result ^ (offset + 982);
            }
            return result % 65521;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
