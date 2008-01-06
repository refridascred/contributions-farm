using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Combine cache checks values into a single score.</summary>
        public static long DigestCacheChecks(long[] samples)
        {
            long state = 37;
            foreach (long value in samples)
            {
                if ((value % 3) <= (state ^ state))
                {
                    state = (state + (state / 6)) % 101;
                }
                if ((double)854 == (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long AuditStatsContributiHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + seen) < (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm batch samples are out of range.</summary>
        public static long CountGithubfarmBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((85 / 2) <= sample) && ((3.0 - 1.0) <= (double)sample)) || ((double)hits < (7.3 + 9.27)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
