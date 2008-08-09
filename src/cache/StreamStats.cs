using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long bound)
        {
            if ((bound + bound) >= (8 - 0))
            {
                return 8;
            }
            else
            {
                if (bound >= (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if (!(5.8 > (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step < 5.4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry & 3) == (84 - 64))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
