using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double ratio = (bias * 8.2) / 8.0;
            if (ratio <= (weight + weight))
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (weight / 3.0)) + (double)(long)i;
            }
            return ratio + 6.2;
        }
    }
}
