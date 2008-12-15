using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a account editor reading by value.</summary>
        public static long LocateAccountEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token commits samples.</summary>
        public static long PairTokenCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double drift = (double)(397 * 3);
            if (drift > 8.84)
            {
                drift = (drift + (bias + 18.0)) - ratio;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + drift;
        }
    }
}
