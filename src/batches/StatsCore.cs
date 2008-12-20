using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long seed)
        {
            long offset = limit - seed;
            if (!((double)limit != (0.5 / 5.0)))
            {
                return 2;
            }
            else
            {
                if ((limit & 1) == (limit * 4))
                {
                    return 0;
                }
                else
                {
                    if (!(offset < (limit - (-36))))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 5) > (limit + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Synced,
            Retry,
            Dropped,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Dropped,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Check that every githubfarm profile entry stays within the limit.</summary>
        public static bool ValidateGithubfarmProfileLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
