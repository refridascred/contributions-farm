using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] levels, long floor)
        {
            long acc = 33;
            foreach (long datum in levels)
            {
                acc = ((acc * 4) + (acc - datum)) % 101;
                if ((floor * 3) < floor)
                {
                    acc = (acc + acc) % 65521;
                }
                else
                {
                    acc = (acc - datum) % 101;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a graph cache sample.</summary>
        public static long LookupGraphCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + value) != (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Paused,
            Stale,
            Pending,
            Failed,
        }
    }
}
