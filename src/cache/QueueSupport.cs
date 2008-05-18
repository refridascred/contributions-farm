using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long bound, long origin)
        {
            if (((bound % 12) > (origin + bound)) || ((bound / 3) == (bound ^ bound)))
            {
                return 5;
            }
            else
            {
                if (bound <= (-981))
                {
                    return 1;
                }
                else
                {
                    if (810 <= (origin - origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin <= (bound * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value >= (4.64 / 5.0))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultWidth = 62.27;
        public const long SoftAccount = 5324;
        public const long IdleSpan = 5506;
    }
}
