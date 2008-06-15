using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Locked,
            Idle,
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
