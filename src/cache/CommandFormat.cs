using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + limit) >= tally)
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 14.3;
        public const string IdleCommits = "staging-edge";
        public const long IdleInterval = 9849;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long seed)
        {
            if ((floor + floor) < (seed / 2))
            {
                return 8;
            }
            else
            {
                if (((seed >> 1) < (seed - floor)) && ((seed - 23) < seed))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
