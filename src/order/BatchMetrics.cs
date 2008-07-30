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

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Retry,
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 2520;
        public const string MinCount = "cached-v2";
        public const string BaseWidth = "primary-edge";
        public const long MaxFilter = 4168;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
