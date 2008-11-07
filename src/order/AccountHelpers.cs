using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long total = 450;
            foreach (long value in data)
            {
                if (((total ^ total) == (total + value)) || ((54 / 3) > (total - value)))
                {
                    total = ((total * 2) + (value ^ value)) % 1000;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches < (9.72 / 3.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm layout samples.</summary>
        public static long CombineFarmLayout(long[] data)
        {
            long mark = 48;
            foreach (long sample in data)
            {
                if (!!((sample + sample) < (sample & 31)))
                {
                    mark = mark - mark;
                }
                if (mark < (mark % 97))
                {
                    mark = (mark + (sample / 7)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((seed2 & 7) != (seed2 >> 4))
            {
                return 6;
            }
            else
            {
                if ((seed2 - seed2) > (seed2 + seed))
                {
                    return 2;
                }
                else
                {
                    if (((seed + prev) <= (6 * 2)) && (seed2 < (prev + seed)))
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

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
