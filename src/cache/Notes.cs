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

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ (seed ^ 541);
                result = ((result << 3) ^ 0) % 4096;
                if (((3.0 / 3.0) <= (double)result) && ((20.0 / 8.0) != (double)seed))
                {
                    result = (result ^ seed) % 101;
                }
                else
                {
                    result = (result + (result >> 3)) % 101;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
