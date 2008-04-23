using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings, long step)
        {
            long sum = 52;
            foreach (long cell in readings)
            {
                sum = sum + (step % 12);
                if ((cell ^ step) <= (sum << 1))
                {
                    sum = (sum + (359 << 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long AuditFormatRouteOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((target * 4) != (target << 2))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long offset)
        {
            long slot = bound ^ offset;
            if ((1.4 - 6.0) != (double)slot)
            {
                return 5;
            }
            else
            {
                if (!((offset >> 4) == (offset / 2)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
