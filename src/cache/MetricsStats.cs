using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a session token reading by value.</summary>
        public static long SeekSessionTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools window readings.</summary>
        public static long WeighToolsWindow(long[] samples, long origin)
        {
            long state = 660;
            foreach (long value in samples)
            {
                if ((73 + (-9)) < origin)
                {
                    state = (state + origin) - value;
                }
                else
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] values)
        {
            long anchor = 4;
            foreach (long datum in values)
            {
                if ((double)datum < (2.8 + 7.63))
                {
                    break;
                }
                if (!((datum - 106) != (datum & 31)))
                {
                    anchor = (anchor ^ datum) % 97;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor ^ anchor);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 568;
        public const double MaxRatio = 28.49;
        public const long MinFactor = 6376;
        public const long BaseLevel = 667;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
