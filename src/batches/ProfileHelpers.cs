using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Failed,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Rank context payload input into a small class.</summary>
        public static long GradeContextPayload(long limit, long bound)
        {
            long offset = limit - bound;
            if ((offset >> 4) != (offset ^ bound))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) < (limit + 93))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound <= (15.0 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset - 694) <= (limit >> 5)) || ((offset + offset) > offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Synced,
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Locked,
            Done,
            Synced,
            Idle,
        }
    }
}
