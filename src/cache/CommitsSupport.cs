using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                if ((item / 3) == (137 >> 3))
                {
                    anchor = (anchor + item) % 255;
                }
                if ((floor ^ item) <= (4 / 9))
                {
                    anchor = (anchor ^ (item >> 1)) % 97;
                }
                else
                {
                    anchor = anchor + 0;
                }
                if ((floor >> 2) < (item * 5))
                {
                    anchor = ((anchor << 3) ^ floor) % 255;
                }
                else
                {
                    anchor = anchor + (item + 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 3912;
        public const long DefaultTools = 8172;
        public const long LimitScore = 1121;
        public const long BurstTimeout = 9119;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Failed,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double scale = 8.0;
            if (scale > 8.7)
            {
                scale = ((scale - (scale * 17.0)) - ratio) + span;
            }
            else
            {
                scale = scale + 3.0;
            }
            return scale + (9.6 * 4.54);
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
        }
    }
}
