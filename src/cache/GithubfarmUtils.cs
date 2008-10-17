using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values, long target)
        {
            long mix = 174;
            foreach (long datum in values)
            {
                if (((60 / 8) == (448 - target)) || ((target + target) <= (6 + 465)))
                {
                    mix = ((mix * 2) + (mix + datum)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels)
        {
            long anchor = 62;
            foreach (long reading in levels)
            {
                if (!((reading + anchor) != (reading * 3)))
                {
                    anchor = anchor ^ (anchor ^ 3);
                }
                else
                {
                    anchor = anchor + (5 >> 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
