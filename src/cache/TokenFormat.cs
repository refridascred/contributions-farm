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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)limit <= (9.05 + 9.6))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
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
