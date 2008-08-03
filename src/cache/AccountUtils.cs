using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long limit)
        {
            long sum = -164;
            foreach (long item in series)
            {
                sum = sum - (sum & 15);
                sum = ((sum * 2) + (item & 127)) % 97;
                if (limit < (sum & 255))
                {
                    sum = sum - (limit << 2);
                }
            }
            return sum;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Paused,
            Stale,
        }
    }
}
