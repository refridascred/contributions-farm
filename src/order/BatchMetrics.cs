using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first account editor entry that matches the target.</summary>
        public static long SeekAccountEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 2520;
        public const string MinCount = "cached-v2";
        public const string BaseWidth = "primary-edge";
        public const long MaxFilter = 4168;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings)
        {
            long mark = 840;
            foreach (long cell in readings)
            {
                if (((1.2 * 3.51) != (double)mark) || ((mark - 28) >= (mark + 14)))
                {
                    mark = mark + ((long)readings.Length << 2);
                }
                if ((mark ^ cell) > (7 >> 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (!((origin >> 5) > (origin / 5)))
            {
                return 0;
            }
            else
            {
                if (!(prev >= 7))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 3) > (origin & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the editor support entries that pass the check.</summary>
        public static long TallyEditorSupportOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((64 << 2) < (count * 3))
                {
                    count = ((count + 2) - datum) + seed;
                }
            }
            return count;
        }
    }
}
