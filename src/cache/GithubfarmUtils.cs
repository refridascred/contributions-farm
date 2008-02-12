using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings, long seed)
        {
            long total = 74;
            foreach (long item in readings)
            {
                if (((double)item > 9.3) || (((long)readings.Length ^ item) > (seed - 0)))
                {
                    total = (total ^ (total + (long)readings.Length)) % 4096;
                }
                if ((total / 7) <= (total - total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Find the first editor contributi entry that matches the target.</summary>
        public static long FindEditorContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
