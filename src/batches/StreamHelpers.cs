using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxTimeout = "alpha-edge";
        public const long StepTimeout = 5634;
        public const long IdleGraph = 1121;
        public const string BatchScore = "fallback-1";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - matches) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm cluster reading by value.</summary>
        public static long SeekGithubfarmClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                total = (total << 2) ^ (entry >> 3);
            }
            if (total < 8)
            {
                total = (total + (total + total)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long seed, long floor)
        {
            if ((double)seed <= (4.59 / 8.0))
            {
                return 5;
            }
            else
            {
                if ((-13) <= (floor * 2))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= 9.7)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((15.0 + 9.0) < (double)floor) && ((double)seed <= (4.59 * 10.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
