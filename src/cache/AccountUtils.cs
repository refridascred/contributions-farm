using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long origin)
        {
            long cur = step - origin;
            if (((step * 4) <= (cur ^ origin)) || ((2.0 * 15.0) >= (double)step))
            {
                return 2;
            }
            else
            {
                if (((6.97 - 4.9) >= (double)origin) || ((step % 3) <= (origin ^ origin)))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 3) == (origin + 76))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Ready,
            Retry,
        }
    }
}
