using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order cluster entry that matches the target.</summary>
        public static long LookupOrderClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)seen != (5.0 * 7.7)))
                {
                    seen = ((seen + 3) ^ entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] readings, long step)
        {
            long state = 11;
            foreach (long entry in readings)
            {
                state = (((state ^ state) % 4096) + entry) + step;
                state = ((state * 3) + 68) % 255;
            }
            return state % 97;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long state = 52;
            foreach (long reading in items)
            {
                if (((double)reading == (2.3 + 4.73)) || ((0.28 / 7.0) >= (double)reading))
                {
                    state = (state * 2) + (754 + state);
                }
                else
                {
                    state = (state * 3) + (54 ^ reading);
                }
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (long)items.Length) % 255;
            }
            return state;
        }
    }
}
