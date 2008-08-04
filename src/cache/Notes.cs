using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 2979;
        public const long RetryFarm = 4800;
        public const double DefaultFarm = 90.33;
        public const long WindowFarm = 242;
        public const double RetryRatio = 26.35;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of githubfarm batches entries.</summary>
        public static long FoldGithubfarmBatches(long[] values)
        {
            long state = 47;
            foreach (long sample in values)
            {
                if ((sample < (state % 10)) && (state <= sample))
                {
                    state = (state - state) % 1000;
                }
            }
            if (state > 100)
            {
                state = (state * 3) + (state + state);
            }
            return state;
        }

        /// <summary>Find the first format order entry that matches the target.</summary>
        public static long SeekFormatOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (6.82 * 1.51))
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
