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

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long TallyFarmFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (9 > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

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
