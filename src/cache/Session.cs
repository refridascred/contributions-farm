using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally > (89 * 2)) && (1 > (tally - tally)))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long limit)
        {
            if ((limit % 24) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((double)seed < (7.0 * 6.4)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
