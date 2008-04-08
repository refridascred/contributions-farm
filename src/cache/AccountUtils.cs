using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels, long floor)
        {
            long acc = 50;
            foreach (long item in levels)
            {
                acc = (acc - (item << 3)) % 97;
            }
            if (acc > (-41))
            {
                acc = (acc + (floor - (long)levels.Length)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + 46) < item) || ((item + item) < 18))
                {
                    seen = seen + 1;
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
