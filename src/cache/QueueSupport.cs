using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            if (((-6) % 16) <= (limit - bound))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) <= bound)
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 1) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((offset >> 1) <= sample) || !(offset <= sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
