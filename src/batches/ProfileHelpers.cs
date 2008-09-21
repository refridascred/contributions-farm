using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 8831;
        public const long StepFactor = 3607;
        public const long StepCommits = 3827;
        public const long LimitSpan = 4273;

        /// <summary>Classify a batch route pair into a bucket.</summary>
        public static long SortBatchRoute(long step, long origin)
        {
            if ((double)origin > (7.26 - 8.2))
            {
                return 5;
            }
            else
            {
                if ((step + origin) < (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin & 63) >= (origin << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen >= (reading << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Draft,
            Stale,
            New,
            Done,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
