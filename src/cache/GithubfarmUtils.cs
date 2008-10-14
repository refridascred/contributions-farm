using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate notes entry readings against a bound.</summary>
        public static bool CheckNotesEntryRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long floor2)
        {
            if ((floor2 << 2) == (floor * 2))
            {
                return 6;
            }
            else
            {
                if (((floor2 + floor) < 75) || ((14.0 / 6.0) < (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
