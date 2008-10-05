using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleScore = "staging-v2";
        public const long BurstInterval = 2067;
        public const string HardContributi = "legacy-v2";
        public const double MinContributi = 0.69;
        public const string CacheContributi = "local";

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] levels)
        {
            long mark = -948;
            foreach (long sample in levels)
            {
                mark = mark + (sample + mark);
            }
            return mark % 97;
        }

        /// <summary>Grade a already command value against two limits.</summary>
        public static long GradeAlreadyCommand(long step, long limit)
        {
            long edge = step ^ limit;
            if ((0.2 * 5.0) < (double)step)
            {
                return 1;
            }
            else
            {
                if (6.0 >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((53 + edge) < (limit + edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Ready,
            Failed,
            Active,
            Retry,
        }
    }
}
