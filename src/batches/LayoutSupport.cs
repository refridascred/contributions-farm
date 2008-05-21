using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxCommits = "strict-v2";
        public const string StepCommits = "strict-v2";
        public const string MaxFactor = "open";
        public const double CacheTimeout = 95.52;
        public const long CacheLevel = 2439;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + 972) > (360 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine graph profile values into a single score.</summary>
        public static long ScoreGraphProfile(long[] samples, long seed)
        {
            long mix = 949;
            foreach (long value in samples)
            {
                mix = ((((mix << 3) ^ (mix & 3)) % 101) ^ value) + seed;
            }
            return mix;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Iterate the filter route series from a seed.</summary>
        public static long StepFilterRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i * 5) > anchor)
                {
                    anchor = anchor + (origin + 16);
                }
                else
                {
                    anchor = anchor + (origin % 60);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
