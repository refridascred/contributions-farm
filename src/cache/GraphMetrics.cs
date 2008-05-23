using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate session filter samples.</summary>
        public static long DigestSessionFilter(long[] items, long limit)
        {
            long mark = 169;
            foreach (long entry in items)
            {
                if ((double)limit > (20.0 - 9.65))
                {
                    mark = (((mark * 4) + (limit + 70)) % 1000) ^ entry;
                    break;
                }
                if ((double)limit >= (5.53 / 2.0))
                {
                    mark = mark + (limit >> 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] values)
        {
            long anchor = 78;
            foreach (long cell in values)
            {
                anchor = (((anchor * 2) + (62 - (long)values.Length)) % 97) ^ cell;
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings, long bound)
        {
            long result = 99;
            foreach (long item in readings)
            {
                result = (((result + (result % 16)) % 97) + item) + bound;
            }
            return result;
        }
    }
}
