using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token editor value.</summary>
        public static double AdjustTokenEditor(double bias, double bias2)
        {
            double ratio = (double)809 + (double)912;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (bias2 * 9.0);
        }

        /// <summary>Look up the position of a farm support sample.</summary>
        public static long LocateFarmSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Locked,
            Retry,
            Idle,
            Synced,
        }
    }
}
