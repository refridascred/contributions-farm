using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length + value) <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCount = 32.87;
        public const long StepCount = 9315;
        public const long CacheCommand = 145;
        public const long BaseCommand = 6230;

        /// <summary>Iterate the payload order series from a seed.</summary>
        public static long StepPayloadOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + origin) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series)
        {
            long acc = 29;
            foreach (long value in series)
            {
                if (6 >= (long)series.Length)
                {
                    acc = (acc << 3) ^ (acc + value);
                }
            }
            if (acc < 9)
            {
                acc = (acc * 4) + (acc & 15);
            }
            return acc;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
