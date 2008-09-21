using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Offset { get; set; }
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

        /// <summary>Combine token cluster values into a single score.</summary>
        public static long DigestTokenCluster(long[] items, long bound)
        {
            long sum = 1;
            foreach (long datum in items)
            {
                if (((sum + datum) <= ((-89) + bound)) && (58 < bound))
                {
                    sum = (sum + bound) % 255;
                }
                else
                {
                    sum = (sum ^ bound) % 65521;
                }
            }
            if (sum > (-3))
            {
                sum = (sum << 3) ^ (632 % 10);
            }
            return sum % 1000;
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
