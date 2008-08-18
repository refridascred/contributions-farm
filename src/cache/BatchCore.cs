using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first metrics githubfarm entry that matches the target.</summary>
        public static long LookupMetricsGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxInterval = 44.91;
        public const long StepFormat = 2197;
        public const string MaxFormat = "legacy-v2";
        public const long DefaultFormat = 7130;
        public const long IdleWidth = 6546;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >= (280 / 6)) && ((offset % 64) > (sample ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
