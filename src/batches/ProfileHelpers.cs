using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value ^ offset) >= value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long target)
        {
            long gap = step ^ target;
            if ((8.0 * 2.3) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((double)gap > (0.28 * 4.8))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 94.0;
        public const long LimitRecord = 5222;
        public const long BurstRecord = 4794;
        public const string DefaultRecord = "legacy-v2";
        public const long MinRecord = 5070;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Idle,
            Locked,
            Paused,
        }
    }
}
