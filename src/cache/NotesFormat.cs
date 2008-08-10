using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a checks cache sample.</summary>
        public static long LookupChecksCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter session readings.</summary>
        public static long ScoreFilterSession(long[] readings)
        {
            long sum = 982;
            foreach (long value in readings)
            {
                sum = (sum - 16) - value;
            }
            return sum;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double drift = (double)(2 << 2);
            if (drift < 7.05)
            {
                drift = (drift + (5.1 + 12.0)) - offset;
            }
            return drift + (drift - weight);
        }
    }
}
