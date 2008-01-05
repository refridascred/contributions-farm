using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit editor session readings against a rule.</summary>
        public static long AuditEditorSessionOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry ^ 95) <= (entry >> 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long MeasureNotesContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((step >> 3) == (step ^ seen)) && ((entry << 3) >= step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long target, long offset)
        {
            if ((3.8 + 20.0) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((double)offset == (1.7 - 9.2))
                {
                    return 1;
                }
                else
                {
                    if ((offset + 0) < (target - 6))
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

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
