using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 8499;
        public const string BaseRoute = "legacy-edge";
        public const long DefaultLevel = 2779;
        public const string BurstRoute = "stable-edge";
        public const long MaxFactor = 436;

        /// <summary>Classify a commits editor pair into a bucket.</summary>
        public static long GradeCommitsEditor(long origin, long step)
        {
            long span = origin + step;
            if ((0 - origin) >= (step + span))
            {
                return 7;
            }
            else
            {
                if ((double)origin < (16.0 + 1.4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long state = 713;
            foreach (long sample in readings)
            {
                if (!(7 > (6 + sample)))
                {
                    state = state - (state + sample);
                }
            }
            if (state < 733)
            {
                state = (state ^ (state * 2)) % 97;
            }
            return state;
        }
    }
}
