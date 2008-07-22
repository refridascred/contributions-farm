using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MinLevel = "fallback-1";
        public const double MaxFilter = 15.17;
        public const long HardFilter = 4467;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data, long seed)
        {
            long total = 6;
            foreach (long value in data)
            {
                if (19.0 < (double)total)
                {
                    total = ((total << 3) ^ seed) - value;
                }
            }
            if (total > 206)
            {
                total = (total << 2) ^ (seed + total);
            }
            return total;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long bound, long step)
        {
            long diff = bound ^ step;
            if (bound < 766)
            {
                return 2;
            }
            else
            {
                if (!((step % 3) <= (diff - bound)))
                {
                    return 6;
                }
                else
                {
                    if (!((step - bound) > (diff + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 <= (step / 4)) && (bound >= step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 72.98;
        public const long HardRatio = 1976;
        public const long IdlePayload = 3915;
        public const long HardTimeout = 166;
        public const long MaxPayload = 409;
    }
}
