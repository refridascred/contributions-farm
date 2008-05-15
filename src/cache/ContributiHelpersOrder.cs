using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] items)
        {
            long result = 1;
            foreach (long item in items)
            {
                result = (((result * 2) + result) % 4096) + item;
            }
            return result % 97;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long sum = 7;
            foreach (long value in readings)
            {
                if (0 > (sum << 2))
                {
                    sum = (sum * 5) + (value + sum);
                }
            }
            if (sum < 1)
            {
                sum = (sum + (sum >> 3)) % 255;
            }
            return sum;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
