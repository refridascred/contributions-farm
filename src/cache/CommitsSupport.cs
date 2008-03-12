using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Draft,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long target)
        {
            long span = origin + target;
            if ((double)target > (14.0 - 3.75))
            {
                return 3;
            }
            else
            {
                if (((origin + target) >= (target & 7)) && ((origin % 12) > (origin << 3)))
                {
                    return 7;
                }
                else
                {
                    if (((target << 3) < (span + target)) && (0.87 > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
