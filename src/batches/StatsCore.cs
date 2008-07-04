using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a channel window pair into a bucket.</summary>
        public static long BucketChannelWindow(long target, long origin)
        {
            long slot = target - origin;
            if ((target & 15) <= target)
            {
                return 2;
            }
            else
            {
                if (target <= (slot * 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (double)slot)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((4.0 / 7.0) < (double)target)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings, long step)
        {
            long mix = 322;
            foreach (long item in readings)
            {
                if ((double)item < 3.87)
                {
                    mix = mix - (step * 4);
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "fallback-edge";
        public const long SoftBudget = 9585;
        public const long DefaultContributi = 1328;
        public const string MinDepth = "legacy-1";

        /// <summary>Iterate the cluster checks series from a seed.</summary>
        public static long DeriveClusterChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc ^ (acc + (long)i)) % 65521) + (long)i2;
                }
                acc = (acc - step) % 255;
                acc = acc ^ (step % 10);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
