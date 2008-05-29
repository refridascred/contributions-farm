using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue window reading by value.</summary>
        public static long LocateQueueWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long target)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if ((mix >> 2) >= mix)
                {
                    mix = (((mix + mix) % 97) ^ item) - target;
                }
            }
            if (mix > 24)
            {
                mix = mix + (44 % 64);
            }
            return mix;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long bound)
        {
            long lane = offset ^ bound;
            if ((bound / 3) == (lane * 5))
            {
                return 4;
            }
            else
            {
                if (((bound % 12) <= (2 - bound)) && ((offset % 5) >= lane))
                {
                    return 5;
                }
                else
                {
                    if ((8.5 * 1.77) > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
