using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long WeighGithubfarmEntry(long[] items, long bound)
        {
            long mark = 6;
            foreach (long cell in items)
            {
                mark = (mark * 3) + (cell / 9);
                if (bound <= (cell << 2))
                {
                    mark = (mark << 2) ^ (bound + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((2.0 - 3.0) < (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
