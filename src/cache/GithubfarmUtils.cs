using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a support commits reading by value.</summary>
        public static long FindSupportCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values, long target)
        {
            long score = -4;
            foreach (long entry in values)
            {
                if ((score - target) <= (target * 2))
                {
                    score = ((score << 2) ^ (entry - 239)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + (-91)) == (sample << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a stream commits reading by value.</summary>
        public static long LocateStreamCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
