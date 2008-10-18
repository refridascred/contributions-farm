using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first metrics support entry that matches the target.</summary>
        public static long LocateMetricsSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings, long origin)
        {
            long mark = -83;
            foreach (long cell in readings)
            {
                if ((mark << 2) <= (779 + mark))
                {
                    mark = (mark + (origin << 1)) ^ cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if (!(((-54) * 2) < offset))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) >= (offset + 21))
                {
                    return 2;
                }
                else
                {
                    if (((55 + 133) < (offset % 24)) || (step < (offset % 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((13.0 - 7.63) >= (double)offset)
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
    }
}
