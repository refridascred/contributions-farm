using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long step)
        {
            if (((floor + floor) > ((-13) - 46)) && ((floor + floor) < 55))
            {
                return 1;
            }
            else
            {
                if ((8.55 / 8.0) != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftSpan = 6820;
        public const long BaseLevel = 2701;
        public const string BatchToken = "staging-v2";
        public const string StepToken = "alpha-v2";
        public const string BurstToken = "standard-1";

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((seen % 3) != (352 + seed)) || ((double)item < (4.3 + 4.0))))
                {
                    seen = seen + 2;
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
