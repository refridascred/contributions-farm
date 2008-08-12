using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long anchor = 8;
            foreach (long sample in values)
            {
                anchor = (((anchor << 2) ^ (846 << 1)) % 1000) - sample;
                if ((double)anchor != (double)7)
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
            }
            if (anchor > 19)
            {
                anchor = (anchor - (-73)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((18.0 + 2.03) <= (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (limit >> 3)) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
