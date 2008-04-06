using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count format stream pairs that satisfy a relation.</summary>
        public static long MatchFormatStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data)
        {
            long anchor = 1;
            foreach (long cell in data)
            {
                if (anchor >= cell)
                {
                    anchor = ((anchor * 3) + cell) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Paused,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Adjust a graph window reading.</summary>
        public static double ScaleGraphWindow(double weight, double offset)
        {
            double gain = (double)((-524) - 74);
            if (gain > offset)
            {
                gain = gain + (weight + gain);
            }
            return gain + 9.47;
        }
    }
}
