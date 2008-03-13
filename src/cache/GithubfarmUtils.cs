using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((12 & 3) < (count / 3))
                {
                    count = ((count + 1) + reading) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((origin >> 4) >= (origin ^ reading)) || ((count % 64) >= ((-915) << 3))) || ((count >> 2) >= (count + 546)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Paused,
            Idle,
            Locked,
        }
    }
}
