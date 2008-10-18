using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many already entry samples are out of range.</summary>
        public static long MeasureAlreadyEntryMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((double)seen != (5.5 + 5.87)))
                {
                    seen = ((seen + 2) + datum) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading / 2) >= (matches / 8))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
