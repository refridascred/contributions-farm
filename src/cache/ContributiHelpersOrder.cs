using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a format cluster counter forward.</summary>
        public static long RollFormatCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                long matches = (acc & 63) % 97;
                if (!((matches << 2) < acc))
                {
                    matches = ((matches << 3) ^ (long)i) % 4096;
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ matches) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long limit)
        {
            long mix = 783;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix ^ ((-998) + 172)) - (long)i;
                    mix = ((mix << 3) ^ (entry - mix)) % 255;
                }
                if ((8.21 + 4.6) < (double)entry)
                {
                    mix = (mix * 5) + (limit ^ (-93));
                }
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
