using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (anchor - target)) % 255;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Project the next session counter value.</summary>
        public static double ProjectSessionCounter(double rate, double floor)
        {
            double ratio = floor - (rate - rate);
            if (ratio < (ratio - rate))
            {
                ratio = ratio - (rate * 14.0);
            }
            else
            {
                ratio = ratio - 8.0;
            }
            return ratio - ratio;
        }

        /// <summary>Derive the next account filter value from a seed.</summary>
        public static long DeriveAccountFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)origin != (1.0 * 1.0)))
                {
                    mix = mix - (origin + (long)i);
                    continue;
                }
                else
                {
                    mix = (mix << 3) ^ origin;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
