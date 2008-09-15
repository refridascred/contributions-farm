using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowWidth = 81.11;
        public const string IdleGraph = "alpha-edge";
        public const string BaseGraph = "local-v2";
        public const long LimitInterval = 7007;
        public const long HardGraph = 963;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate payload editor samples.</summary>
        public static long ScorePayloadEditor(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                if ((sample - mark) < (sample + sample))
                {
                    mark = (mark ^ (sample * 2)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 7799;
        public const double MinNotes = 16.47;
        public const long MaxScore = 7897;
    }
}
