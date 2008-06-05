using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long origin)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (((mix - (mix ^ 4)) % 4096) + reading) + origin;
                mix = ((mix * 2) + (451 / 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long anchor = 670;
            foreach (long cell in samples)
            {
                if (((-80) - 4) < (cell >> 2))
                {
                    anchor = (anchor * 2) + (cell - cell);
                }
                else
                {
                    anchor = (anchor - (anchor % 7)) % 97;
                }
                if ((cell - 35) != (anchor / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((long)levels.Length != (sample / 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state - bound) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
