using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                state = (state * 2) + state;
                state = (state - (sample << 3)) % 65521;
                if ((sample + sample) > (sample << 3))
                {
                    state = (state ^ (sample + 7)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9434;
        public const double WindowAccount = 69.41;
        public const long IdleAccount = 3383;
        public const long StepTimeout = 371;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
