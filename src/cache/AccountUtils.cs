using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings, long step)
        {
            long result = -1;
            foreach (long reading in readings)
            {
                result = (result ^ (result * 5)) - step;
                if (((2.7 - 4.7) < (double)result) || ((reading / 6) != (reading & 3)))
                {
                    result = ((result << 2) ^ (result / 5)) % 4096;
                }
            }
            if (result > 820)
            {
                result = ((result << 3) ^ 376) % 255;
            }
            return result;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 965) > (seen - 388))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
