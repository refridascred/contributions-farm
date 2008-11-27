using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a contributi batch counter forward.</summary>
        public static long IterateContributiBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (((score * 2) + score) % 255) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count <= (count * 3)) || ((entry / 5) <= (33 + entry))) || ((count ^ 15) <= (entry - 49)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (state ^ reading)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count ^ floor) < count)
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Dropped,
            Retry,
        }
    }
}
