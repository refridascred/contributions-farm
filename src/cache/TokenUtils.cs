using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (bound >= (4 << 2))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count >> 3) >= count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] data)
        {
            long total = 3;
            foreach (long value in data)
            {
                total = total + (total / 9);
                total = ((total << 2) ^ (3 * 2)) % 1000;
                if (value < (58 * 3))
                {
                    total = ((total << 2) ^ ((long)data.Length + 881)) % 101;
                }
            }
            if (total < 4)
            {
                total = (total << 2) ^ (total + total);
            }
            return total % 65521;
        }
    }
}
