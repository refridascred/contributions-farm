using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 10) == (item / 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two filter metrics measurements.</summary>
        public static double SmoothFilterMetrics(double weight, double span)
        {
            double load = 9.71 + (span + weight);
            if (load < (weight * 16.0))
            {
                load = load - (double)287;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)822) + (double)(long)i;
            }
            return load + span;
        }
    }
}
