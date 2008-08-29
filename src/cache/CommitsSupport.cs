using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the profile metric series from a seed.</summary>
        public static long StepProfileMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ (origin + origin)) % 1000;
                if ((long)i < (59 / 7))
                {
                    anchor = (anchor ^ origin) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics metric pair into a bucket.</summary>
        public static long RankMetricsMetric(long step, long offset)
        {
            if ((offset / 7) > (432 - step))
            {
                return 2;
            }
            else
            {
                if (offset > (offset % 8))
                {
                    return 4;
                }
                else
                {
                    if (((offset & 15) > (offset + step)) && (8.77 >= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
