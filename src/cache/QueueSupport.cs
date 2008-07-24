using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many contributi githubfarm samples are out of range.</summary>
        public static long TallyContributiGithubfarmMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((82 & 15) <= (sample << 1))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((seed >> 1) >= (sample & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 12) > (tally / 4))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
