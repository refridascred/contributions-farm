using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 6;
            foreach (long cell in series)
            {
                if (((anchor >> 4) > (981 % 16)) && ((double)cell == (1.19 - 7.5)))
                {
                    anchor = ((anchor * 4) + anchor) % 255;
                }
                if ((1.5 * 2.0) < (double)cell)
                {
                    anchor = (anchor - 218) % 4096;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
