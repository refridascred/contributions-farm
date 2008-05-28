using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm batches entries that pass the check.</summary>
        public static long TallyGithubfarmBatchesMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((tally << 2) >= 6))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long bound)
        {
            if ((double)origin >= (10.0 - 4.0))
            {
                return 0;
            }
            else
            {
                if ((bound + 21) > 25)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxTimeout = 59.31;
        public const long StepRatio = 3875;
        public const long BatchBatches = 1084;
    }
}
