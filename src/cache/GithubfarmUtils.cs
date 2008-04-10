using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchDepth = 6460;
        public const double WindowScore = 46.13;
        public const long HardSize = 4961;
        public const long LimitProfile = 3835;

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double weight = 5.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (5.0 - weight)) + (double)(long)i) - span;
            }
            return weight + (9.6 + gain);
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
