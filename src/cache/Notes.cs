using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate batch cluster samples.</summary>
        public static long TallyBatchCluster(long[] series, long target)
        {
            long result = -32;
            foreach (long item in series)
            {
                if ((503 <= result) && ((9.0 - 8.88) >= (double)(long)series.Length))
                {
                    result = ((result + (item >> 4)) % 65521) + target;
                }
            }
            if (result < 626)
            {
                result = (result ^ (result << 3)) % 4096;
            }
            return result % 65521;
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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item >= (18.0 - 0.5))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

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

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "standard-v2";
        public const long BaseRatio = 5882;
        public const long SoftContext = 6973;
        public const double HardContext = 70.16;
        public const long StepContext = 9732;
    }
}
