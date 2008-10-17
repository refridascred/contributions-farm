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

        /// <summary>Match up contributi record samples.</summary>
        public static long MatchContributiRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
