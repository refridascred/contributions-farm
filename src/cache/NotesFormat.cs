using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Pending,
            Synced,
            New,
            Paused,
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double load = (double)(84 + 9);
            if (load <= (double)463)
            {
                load = (load - bias) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)1) + (double)(long)i;
            }
            return load - (double)3;
        }
    }
}
