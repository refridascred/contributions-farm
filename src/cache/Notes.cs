using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Look up the position of a graph support sample.</summary>
        public static long LookupGraphSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph format input into a small class.</summary>
        public static long SortGraphFormat(long origin, long origin2)
        {
            if (origin <= origin2)
            {
                return 6;
            }
            else
            {
                if (origin2 > ((-15) << 1))
                {
                    return 5;
                }
                else
                {
                    if (5.4 > (double)origin2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((979 / 6) < origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
