using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long bound)
        {
            if (632 >= (floor + 1))
            {
                return 7;
            }
            else
            {
                if ((81 >> 4) > floor)
                {
                    return 3;
                }
                else
                {
                    if ((double)4 <= (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Active,
            Synced,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long origin, long origin2)
        {
            if (10.0 <= (double)origin2)
            {
                return 3;
            }
            else
            {
                if ((double)origin <= 8.6)
                {
                    return 6;
                }
                else
                {
                    if ((origin2 / 6) > 4)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 + origin2) >= (origin2 - origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - matches) != ((long)readings.Length & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
