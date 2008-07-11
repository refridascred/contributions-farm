using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long bound)
        {
            long mix = 60;
            foreach (long cell in series)
            {
                mix = mix - (cell & 7);
                mix = (mix - (bound % 100)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 305;
        public const double MinRatio = 27.24;
        public const long BatchLevel = 1518;
        public const long HardToken = 9984;
        public const double DefaultFactor = 56.57;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
