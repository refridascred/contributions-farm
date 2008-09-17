using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 3) ^ floor) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the layout account entries that pass the check.</summary>
        public static long TallyLayoutAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (1.0 - 20.0))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Audit graph commits readings against a rule.</summary>
        public static long TallyGraphCommitsGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - sample) > (399 >> 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
