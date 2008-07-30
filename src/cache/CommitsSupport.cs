using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)limit < (0.1 - 7.8))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double floor)
        {
            double rate = 8.0;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)79) + (double)(long)i;
            }
            return rate + (gain + floor);
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long step)
        {
            if ((offset % 64) == (offset & 255))
            {
                return 0;
            }
            else
            {
                if ((step * 5) <= (step % 12))
                {
                    return 7;
                }
                else
                {
                    if ((27 > (offset / 5)) && (6.8 < (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + offset) > offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Ready,
            Idle,
            Retry,
            Closed,
        }
    }
}
