using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)floor != (double)tally)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            New,
            Idle,
            Locked,
        }

        /// <summary>Classify a route context pair into a bucket.</summary>
        public static long RankRouteContext(long target, long step)
        {
            long slot = target ^ step;
            if ((0 - step) < 9)
            {
                return 1;
            }
            else
            {
                if ((1.0 / 5.0) != (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((slot % 60) != (target & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - step) <= target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCount = 1024;
        public const long IdleCommits = 8241;
        public const long BatchTimeout = 4810;
        public const string RetryScore = "fallback-v2";
    }
}
