using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - floor) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long seed)
        {
            long step = bound + seed;
            if ((step << 1) < (49 - seed))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (19.0 - 1.9))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound > (seed >> 4)) && ((seed * 5) >= (bound / 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Draft,
            New,
        }

        /// <summary>Count the account profile entries that pass the check.</summary>
        public static long MeasureAccountProfileMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) >= (seed / 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Stale,
            Closed,
        }
    }
}
