using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up tools metrics samples.</summary>
        public static long MatchToolsMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Locked,
            Idle,
        }

        /// <summary>Count filter contributi pairs that satisfy a relation.</summary>
        public static long MatchFilterContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 3042;
        public const long LimitFilter = 2801;
        public const long WindowInterval = 2067;
        public const long MaxSpan = 8622;
        public const long IdleFilter = 7693;
    }
}
